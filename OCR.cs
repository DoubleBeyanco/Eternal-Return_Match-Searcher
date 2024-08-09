using System.Reflection;
using OpenCvSharp;
using Sdcb.PaddleInference;
using Sdcb.PaddleOCR.Models;
using Sdcb.PaddleOCR;
using Sdcb.PaddleOCR.Models.Local;
using System;

public class OCR
{
    public enum Language
    {
        Korean, Chinese, Japanese, English, None
    }

    public enum Player
    {
        A, B, C, None
    }

    public static float[,] OCRtable = new float[3, 4];

    public string PlayerA = null;
    public string PlayerB = null;
    public string PlayerC = null;


    public void PlayerResult()
    {
        OCRDetect_Ko();
        OCRDetect_Cn();
        OCRDetect_Jp();
        //OCRDetect_En();

        PlayerA = OCRDetect(AnalyzeData(Player.A))[(int)Player.A];
        PlayerB = OCRDetect(AnalyzeData(Player.B))[(int)Player.B];
        PlayerC = OCRDetect(AnalyzeData(Player.C))[(int)Player.C];

    }

    private Language AnalyzeData(Player _index)
    {
        float result = OCRtable[(int)_index, 0];
        Dictionary<Player, Language> temp = new Dictionary<Player, Language>();
        for (int i = 0; i < 4; ++i)
        {
            float tempValue = OCRtable[(int)_index, i];

            if (tempValue > result)
            {
                result = tempValue;
            }
        }

        for (int i = 0; i < 4; ++i)
        {
            if (OCRtable[(int)_index, i] == result)
            {
                return (Language)i;
            }
        }

        return Language.None;

    }

    private string[] OCRDetect(Language _language)
    {
        // 이 방식 활용하면 최소 한국어 중국어 영어 일본어를 전체 순회하면서 일치율 0.9가 넘는 애들로만 닉을 추적해야할 듯하다.
        // 좌표값은 큰 차이가 안날 것이기 때문에 좌표 범위 설정하고 그 안에 있는 문자열만 추적하도록 하면될 듯하다.
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        FullOcrModel _model;
        switch (_language)
        {
            case Language.English:
                _model = LocalFullModels.EnglishV4;
                break;
            case Language.Japanese:
                _model = LocalFullModels.JapanV4;
                break;
            case Language.Korean:
                _model = LocalFullModels.KoreanV4;
                break;
            case Language.Chinese:
                _model = LocalFullModels.ChineseV4;
                break;
            default:
                _model = LocalFullModels.KoreanV4;
                break;
        }

        string[] temp = new string[3];

        using (PaddleOcrAll all = new PaddleOcrAll(_model, PaddleDevice.Mkldnn())
        {
            AllowRotateDetection = true, /* 각도가 있는 문자를 인식하도록 허용 */
            Enable180Classification = false, /* 90도 이상 회전된 문자를 인식하지 않도록 설정 */
        })
        {
            // Load local file by following code:
            using (Mat src2 = Cv2.ImRead(path + @"\images\" + "Detect" + @".png"))
            //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
            {
                PaddleOcrResult result = all.Run(src2);
                foreach (PaddleOcrResultRegion region in result.Regions)
                {
                    //Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                    if (region.Rect.Center.X > 1100f && region.Rect.Center.X < 1200f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        temp[(int)Player.A] = region.Text;
                    }
                    else if (region.Rect.Center.X > 1400f && region.Rect.Center.X < 1500f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        temp[(int)Player.B] = region.Text;
                    }
                    else if (region.Rect.Center.X > 1700f && region.Rect.Center.X < 1800f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        temp[(int)Player.C] = region.Text;
                    }
                }

                return temp;
            }
        }
    }

    private void OCRDetect_Ko()
    {
        // 이 방식 활용하면 최소 한국어 중국어 영어 일본어를 전체 순회하면서 일치율 0.9가 넘는 애들로만 닉을 추적해야할 듯하다.
        // 좌표값은 큰 차이가 안날 것이기 때문에 좌표 범위 설정하고 그 안에 있는 문자열만 추적하도록 하면될 듯하다.
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        FullOcrModel model = LocalFullModels.KoreanV4;

        using (PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Mkldnn())
        {
            AllowRotateDetection = true, /* 각도가 있는 문자를 인식하도록 허용 */
            Enable180Classification = false, /* 90도 이상 회전된 문자를 인식하지 않도록 설정 */
        })
        {
            // Load local file by following code:
            using (Mat src2 = Cv2.ImRead(path + @"\images\" + "Detect" + @".png"))
            //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
            {
                PaddleOcrResult result = all.Run(src2);
                foreach (PaddleOcrResultRegion region in result.Regions)
                {
                    //Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                    if (region.Rect.Center.X > 1100f && region.Rect.Center.X < 1200f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.A, (int)Language.Korean] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1400f && region.Rect.Center.X < 1500f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.B, (int)Language.Korean] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1700f && region.Rect.Center.X < 1800f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.C, (int)Language.Korean] = region.Score;
                    }
                }
            }
        }
    }
    private void OCRDetect_Cn()
    {
        // 이 방식 활용하면 최소 한국어 중국어 영어 일본어를 전체 순회하면서 일치율 0.9가 넘는 애들로만 닉을 추적해야할 듯하다.
        // 좌표값은 큰 차이가 안날 것이기 때문에 좌표 범위 설정하고 그 안에 있는 문자열만 추적하도록 하면될 듯하다.
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        FullOcrModel model = LocalFullModels.ChineseV4;

        using (PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Mkldnn())
        {
            AllowRotateDetection = true, /* 각도가 있는 문자를 인식하도록 허용 */
            Enable180Classification = false, /* 90도 이상 회전된 문자를 인식하지 않도록 설정 */
        })
        {
            // Load local file by following code:
            using (Mat src2 = Cv2.ImRead(path + @"\images\" + "Detect" + @".png"))
            //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
            {
                PaddleOcrResult result = all.Run(src2);
                foreach (PaddleOcrResultRegion region in result.Regions)
                {
                    //Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                    if (region.Rect.Center.X > 1100f && region.Rect.Center.X < 1200f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.A, (int)Language.Chinese] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1400f && region.Rect.Center.X < 1500f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.B, (int)Language.Chinese] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1700f && region.Rect.Center.X < 1800f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.C, (int)Language.Chinese] = region.Score;
                    }
                }
            }
        }
    }
    private void OCRDetect_Jp()
    {
        // 이 방식 활용하면 최소 한국어 중국어 영어 일본어를 전체 순회하면서 일치율 0.9가 넘는 애들로만 닉을 추적해야할 듯하다.
        // 좌표값은 큰 차이가 안날 것이기 때문에 좌표 범위 설정하고 그 안에 있는 문자열만 추적하도록 하면될 듯하다.
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        FullOcrModel model = LocalFullModels.JapanV4;

        using (PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Mkldnn())
        {
            AllowRotateDetection = true, /* 각도가 있는 문자를 인식하도록 허용 */
            Enable180Classification = false, /* 90도 이상 회전된 문자를 인식하지 않도록 설정 */
        })
        {
            // Load local file by following code:
            using (Mat src2 = Cv2.ImRead(path + @"\images\" + "Detect" + @".png"))
            //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
            {
                PaddleOcrResult result = all.Run(src2);
                foreach (PaddleOcrResultRegion region in result.Regions)
                {
                    //Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                    if (region.Rect.Center.X > 1100f && region.Rect.Center.X < 1200f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.A, (int)Language.Japanese] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1400f && region.Rect.Center.X < 1500f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.B, (int)Language.Japanese] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1700f && region.Rect.Center.X < 1800f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.C, (int)Language.Japanese] = region.Score;
                    }
                }
            }
        }
    }
    private void OCRDetect_En()
    {
        // 이 방식 활용하면 최소 한국어 중국어 영어 일본어를 전체 순회하면서 일치율 0.9가 넘는 애들로만 닉을 추적해야할 듯하다.
        // 좌표값은 큰 차이가 안날 것이기 때문에 좌표 범위 설정하고 그 안에 있는 문자열만 추적하도록 하면될 듯하다.
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        FullOcrModel model = LocalFullModels.EnglishV4;

        using (PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Mkldnn())
        {
            AllowRotateDetection = true, /* 각도가 있는 문자를 인식하도록 허용 */
            Enable180Classification = false, /* 90도 이상 회전된 문자를 인식하지 않도록 설정 */
        })
        {
            // Load local file by following code:
            using (Mat src2 = Cv2.ImRead(path + @"\images\" + "Detect" + @".png"))
            //using (Mat src = Cv2.ImDecode(sampleImageData, ImreadModes.Color))
            {
                PaddleOcrResult result = all.Run(src2);
                foreach (PaddleOcrResultRegion region in result.Regions)
                {
                    //Console.WriteLine($"Text: {region.Text}, Score: {region.Score}, RectCenter: {region.Rect.Center}, RectSize:    {region.Rect.Size}, Angle: {region.Rect.Angle}");
                    if (region.Rect.Center.X > 1100f && region.Rect.Center.X < 1200f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.A, (int)Language.English] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1400f && region.Rect.Center.X < 1500f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.B, (int)Language.English] = region.Score;
                    }
                    else if (region.Rect.Center.X > 1700f && region.Rect.Center.X < 1800f && region.Rect.Center.Y > 935f && region.Rect.Center.Y < 950f)
                    {
                        OCRtable[(int)Player.C, (int)Language.English] = region.Score;
                    }
                }
            }
        }
    }
}
