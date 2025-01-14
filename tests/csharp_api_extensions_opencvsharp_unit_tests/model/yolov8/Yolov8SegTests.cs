﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCvSharp;
using OpenVinoSharp.Extensions.model;
using OpenVinoSharp.Extensions.result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenVinoSharp.Extensions.model.Tests
{
    [TestClass()]
    public class Yolov8SegTests
    {
        [TestMethod()]
        public void Yolov8Seg_test()
        {
            Yolov8Seg yolo = new Yolov8Seg("..\\..\\..\\..\\..\\model\\yolov8\\yolov8s-seg.xml");
        }

        [TestMethod()]
        public void predict_test()
        {
            Yolov8Seg yolo = new Yolov8Seg("..\\..\\..\\..\\..\\model\\yolov8\\yolov8s-seg.xml");
            Mat image = Cv2.ImRead("..\\..\\..\\..\\..\\dataset\\image\\demo_2.jpg");
            SegResult result = yolo.predict(image);
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void predict_test1()
        {
            Yolov8Seg yolo = new Yolov8Seg("..\\..\\..\\..\\..\\model\\yolov8\\yolov8s-seg.xml");
            List<Mat> images = new List<Mat>();
            images.Add(Cv2.ImRead("..\\..\\..\\..\\..\\dataset\\image\\demo_1.jpg"));
            images.Add(Cv2.ImRead("..\\..\\..\\..\\..\\dataset\\image\\demo_2.jpg"));
            images.Add(Cv2.ImRead("..\\..\\..\\..\\..\\dataset\\image\\demo_3.jpg"));
            List<SegResult> results = yolo.predict(images);
            Assert.IsNotNull(results);
        }

        [TestMethod()]
        public void process_result_test()
        {
            Assert.Fail();
        }
    }
}