/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Test
{
    //HelloworldCfg.cs���������������
    public class Calculator
    {
        //�޸ĳ���ȷ���߼��󣬴�����ע�ͣ����ɵĲ����������ú���
        public int Add(int a, int b)
        {
            return a + b;
        }
        /*�����ڲ���������һ���ӿڣ�newAdd. ����ʱ�ᱨ������
         * [Patch]
        public int Add(int a, int b)
        {
            return newAdd(a,b);
        }
        [Patch]
        public int newAdd(int a, int b)
        {
            return a * b + 10000;
        }*/

        public int Sub(int a, int b)
        {
            return a / b;
        }
    }
}
