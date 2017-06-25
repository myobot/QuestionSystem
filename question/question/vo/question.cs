using System;
using System.Collections.Generic;
using System.Text;

namespace question.vo
{
    class Question
    {
        public int questionid { get; set; }
        public String q_name { get; set; }
        public String c_a { get; set; }
        public String c_b { get; set; }
        public String c_c { get; set; }
        public String c_d { get; set; }
        public int hardlevel { get; set; }
        public int score { get; set; }
        public String answer { get; set; }
    }
}
