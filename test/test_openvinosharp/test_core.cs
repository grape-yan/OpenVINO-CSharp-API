﻿using OpenVinoSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class test_core
    {
        public static void test_version()
        {
            ov_version version = new ov_version();
            Console.WriteLine(version.version.buildNumber);
            Console.WriteLine(version.version.description);
            Console.WriteLine("ov_version 初始化成功！");
            version.free();
            Console.WriteLine("ov_version free成功！");
        }
        public static void test_core_init() 
        {
            Core core = new Core();
            Console.WriteLine("Core 初始化成功！");

            core.free();
            Console.WriteLine("Core free成功！");


        }

        public static void test_core_read_model() {
            Core core = new Core();

            Model model = core.read_model("E:\\Text_Model\\yolov8\\yolov8s.xml");
            Console.WriteLine("Core read_model IR 成功！");

            model.free();
            Console.WriteLine("Model free成功！");

            model = core.read_model(@"E:\Text_Model\yolov8\yolov8s.onnx");
            Console.WriteLine("Core read_model ONNX 成功！");

            model.free();
            Console.WriteLine("Model free成功！");

            model = core.read_model(@"E:\Text_Model\PP-OCR\ppocr_model_v3\rec_paddle\inference.pdmodel");
            Console.WriteLine("Core read_model paddle 成功！");

            model.free();
            Console.WriteLine("Model free成功！");
            core.free();

        }

        public static void test_core_compiled_model() 
        {
            Core core = new Core();

            Model model = core.read_model(@"E:\Text_Model\yolov8\yolov8s.xml");

            CompiledModel compiled_model = core.compiled_model(model, "CPU");
            Console.WriteLine("Core compiled_model()成功！");

            core.free();
        }
    }
}
