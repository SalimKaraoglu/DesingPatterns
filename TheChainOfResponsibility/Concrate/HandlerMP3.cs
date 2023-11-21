﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibility.Abstract;

namespace TheChainOfResponsibility.Concrate
{
    public class HandlerMP3 : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp3"))
            {
                Console.WriteLine($"{fileType} tipinde medya oynatılıyor...");
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(fileType);
                }
            }
        }
    }
}
