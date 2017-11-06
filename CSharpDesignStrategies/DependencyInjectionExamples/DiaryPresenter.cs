using CSharpDesignStrategies.InterfaceExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignStrategies.DependencyInjectionExamples
{
    public class DiaryPresenter
    {
        private Diary diary;
        private License license;

        //public DiaryPresenter(Diary diary)
        //{
        //    this.diary = diary;
        //}

        public DiaryPresenter(Diary diary, License license)
        {
            this.diary = diary;
            this.license = license;
        }

        public void Start()
        {
            Console.WriteLine("Today is: {0}", diary.FormatToday());
            Console.WriteLine("License valid? {0}", license.HasExpired);
        }
    }
}
