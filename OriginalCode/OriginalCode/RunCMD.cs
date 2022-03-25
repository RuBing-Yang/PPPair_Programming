using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OriginalCode
{
    class RunCMD
    {
        static void Main(string[] args)
        {
            string[] words = Program.input(args);
            string[] result = new string[words.Length];
            Chain chain = new Chain();

            switch (GlobalPara.type)
            {
                case 'n':
                    //统计单词链数量 只传递单词链
                    chain.gen_chains_all(words, words.Length, result);
                    break;
                case 'm':
                    //输出首字母不相同的包含单词数量最多的单词链 只传递单词链
                    chain.gen_chain_word_unique(words, words.Length, result);
                    break;
                case 'w':
                    //需要传入Global的参数进行处理
                    chain.gen_chain_word(words, words.Length, result, 
                        GlobalPara.head, GlobalPara.tail, GlobalPara.is_loop);
                    break;
                case 'c':
                    //需要传入Global的参数进行处理
                    chain.gen_chain_char(words, words.Length, result,
                        GlobalPara.head, GlobalPara.tail, GlobalPara.is_loop);
                    break;
            }
        }
    }
}