using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartReatime.Model
{
    public class rcvdat
    {
        public int yrcomm { get; set; }
        public int moncomm { get; set; }
        public int daycomm { get; set; }
        public int hhcomm { get; set; }
        public int mmcomm { get; set; }
        public int sscomm { get; set; }
        public double ttc { get; set; }
        public double wdmd { get; set; }
        public double vc { get; set; }
        public double xsn { get; set; }
        public double ymdl { get; set; }
        public double dtcmn { get; set; }
        public double dtcms { get; set; }
        public double dtcme { get; set; }
        public double dtcmw { get; set; }
        public double tms { get; set; }
        public double wttd { get; set; }
        public double postd { get; set; }
        public double glmf { get; set; }
        public double aems { get; set; }
        public double fems { get; set; }
        public double tcmd { get; set; }
        public int yr { get; set; }
        public int mon { get; set; }
        public int day { get; set; }
        public int hh { get; set; }
        public int mm { get; set; }
        public int ss { get; set; }
        public char chno { get; set; }
        public char gcode { get; set; }
        public int usemd { get; set; }
        public double tprmd { get; set; }
        public int emsomd { get; set; }
        public int emscmd { get; set; }
        public int emsdmd { get; set; }
        public double c_ms { get; set; }
        public double sims { get; set; }
        public double mnms { get; set; }
        public double p_ms { get; set; }
        public double s_ms { get; set; }
        public double nims { get; set; }
        public double crms { get; set; }
        public double tims { get; set; }
        public double v_ms { get; set; }
        public double mo_ms { get; set; }

        public rcvdat(int yrcomm, int moncomm, int daycomm, int hhcomm, int mmcomm, int sscomm, double ttc, double wdmd, double vc, double xsn, double ymdl, double dtcmn, double dtcms, double dtcme, double dtcmw, double tms, double wttd, double postd, double glmf, double aems, double fems, double tcmd, int yr, int mon, int day, int hh, int mm, int ss, char chno, char gcode, int usemd, double tprmd, int emsomd, int emscmd, int emsdmd, double c_ms, double sims, double mnms, double p_ms, double ms, double nims, double crms, double tims, double v_ms, double mo_ms)
        {
            this.yrcomm = yrcomm;
            this.moncomm = moncomm;
            this.daycomm = daycomm;
            this.hhcomm = hhcomm;
            this.mmcomm = mmcomm;
            this.sscomm = sscomm;
            this.ttc = ttc;
            this.wdmd = wdmd;
            this.vc = vc;
            this.xsn = xsn;
            this.ymdl = ymdl;
            this.dtcmn = dtcmn;
            this.dtcms = dtcms;
            this.dtcme = dtcme;
            this.dtcmw = dtcmw;
            this.tms = tms;
            this.wttd = wttd;
            this.postd = postd;
            this.glmf = glmf;
            this.aems = aems;
            this.fems = fems;
            this.tcmd = tcmd;
            this.yr = yr;
            this.mon = mon;
            this.day = day;
            this.hh = hh;
            this.mm = mm;
            this.ss = ss;
            this.chno = chno;
            this.gcode = gcode;
            this.usemd = usemd;
            this.tprmd = tprmd;
            this.emsomd = emsomd;
            this.emscmd = emscmd;
            this.emsdmd = emsdmd;
            this.c_ms = c_ms;
            this.sims = sims;
            this.mnms = mnms;
            this.p_ms = p_ms;
            s_ms = ms;
            this.nims = nims;
            this.crms = crms;
            this.tims = tims;
            this.v_ms = v_ms;
            this.mo_ms = mo_ms;
        }
    }
}
