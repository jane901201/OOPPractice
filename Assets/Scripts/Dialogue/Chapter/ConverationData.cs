﻿using System.Collections;
using UnityEngine;

namespace Unreal.Dialogue
{
    public class ConverationData
    {
        private string[][] converation;
        private int currectChapter;
        private string converationName;

        public int CurrectChapter { get => currectChapter; set => currectChapter = value; }
        public string ConverationName { get => converationName; set => converationName = value; }

        public void Initinal()
        {
            converation = new string[7][];
            converation[0] = new string[]
            {
                "Begin",
                ""
            };
            converation[1] = new string[]
            {
                "",
            };
            converation[2] = new string[]
            {
                "",
                ""
            };
            converation[3] = new string[]
            {
                "",
                ""
            };
            converation[4] = new string[]
            {
                "",
                ""
            };
            converation[5] = new string[]
            {
                "",
                ""
            };
            converation[6] = new string[]
            {
                "",
                ""
            };
        }

        public string[][] GetConveration()
        {
            return converation;
        }

    }
}