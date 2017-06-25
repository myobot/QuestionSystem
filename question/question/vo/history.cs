using System;
using System.Collections.Generic;
using System.Text;

namespace question.vo
{
    class history
    {
        public int historyid { get; set; }
        public String username { get; set; }
        public int questionid { get; set; }
        public String useranswer { get; set; }
        public int rightorwrong { get; set; }
        public int tpid { get; set; }
    }
}
