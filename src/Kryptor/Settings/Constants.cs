﻿using System;
using System.Windows.Forms;

/*  
    Kryptor: Free and open source file encryption software.
    Copyright(C) 2020 Samuel Lucas

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program. If not, see https://www.gnu.org/licenses/. 
*/

namespace Kryptor
{
    public static class Constants
    {
        // Mono runtime
        public static readonly bool RunningOnMono = Type.GetType("Mono.Runtime") != null;

        // Working directory
        public static readonly string KryptorDirectory = Application.StartupPath;

        // Key derivation
        public static readonly int DefaultParallelism = Environment.ProcessorCount;
        public static readonly int Mebibyte = 1024;
        public static readonly int DefaultMemorySize = 100 * Mebibyte;
        public static readonly int DefaultIterations = 1;

        // File encryption
        public const string EncryptedExtension = ".kryptor";
        public const int EncryptionKeySize = 32;
        public const int HMACKeySize = 128;
        public const int SaltLength = 32;
        public const int XChaChaNonceLength = 24;
        public const int AesNonceLength = 16;
        public const int HMACLength = 64;

        // Storing Argon2 parameters in encrypted files
        public const string ParallelismFlag = "|p=";
        public const string MemorySizeFlag = "|m=";
        public const string IterationsFlag = "|t=";
        public const string EndFlag = "|END|";

        // Dark theme Color.FromArgb
        public const int Red = 44;
        public const int Green = 47;
        public const int Blue = 51;
    }

    // For code readability rather than specifying numbers
    public enum Cipher
    {
        XChaCha20,
        XSalsa20,
        AesCBC,
        AesCTR
    }
}