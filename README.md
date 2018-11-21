# Wpf_20181114
存取钱功能界面



小双姐：

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 存取款3
{
    class Program
    {

        static void Main(string[] args)
        {
            int Acc = 10000;//初始账户余额
            Console.WriteLine("账户余额是：{0}", Acc);          
            while (true)
            {
                Console.WriteLine("请选择操作类型：1、存款 2、取款 3、退出");
                int s = Convert.ToInt32(Console.ReadLine());//将输入的字符串转换成数值 



                switch (s)
                {
                    case 1:

                        {
                            Console.WriteLine("请输入存款金额:");
                            int k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("存入金额是{0}元，当前账户余额是{1}元\n\r", k, Acc);
                            //Console.ReadLine();
                            Console.WriteLine("现在账户余额是{0}元,您现在正在进行存款\n\r", Acc + k);

                            Acc = Acc + k;//更新账户余额
                           
                            break;

                        }
                    case 2:

                        {
                            int h;
                            Console.WriteLine("请输入取款金额:");
                            h = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("取款金额是{0}，当前账户余额是{1}元\n\r", h, Acc);

                            while (h - Acc > 0)//判断账户余额是否不足
                            {
                                Console.WriteLine("不能取款");
                                Console.WriteLine("请重新输入取款金额:");
                                h = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("取款金额是{0}，当前账户余额是{1}\n\r", h, Acc);

                                continue;
                            }

                            Console.WriteLine("现在的账户余额是{0}，您现在正在进行取款\n\r", Acc - h);

                            Acc = Acc - h;//更新账户余额
                            break;
                          

                        }
                    case 3:

                        return;  //退出

                    default:
                        {
                            Console.WriteLine("此操作类型不存在");
                            Console.ReadLine();
                          
                            break;
                        }



                }

            }
        }
    }
}
