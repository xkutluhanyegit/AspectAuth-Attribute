using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {

        [Required]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "*Müşteri bilgisi boş bırakılamaz!")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "*Marka bilgisi boş bırakılamaz!")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "*Model bilgisi boş bırakılamaz!")]
        public string Model { get; set; }

        [Required(ErrorMessage = "*Renk veya Boy bilgisi boş bırakılamaz!")]
        public string ColorOrInch { get; set; }

        [Required(ErrorMessage = "*Paket bilgisi boş bırakılamaz!")]
        public string PackageType { get; set; }

        [Required(ErrorMessage = "*Yıkama veya Boyama bilgisi boş bırakılamaz!")]
        public string WashType { get; set; }

        [Required(ErrorMessage = "*İmalat Tarihi boş bırakılamaz!")]
        public string ProductDate { get; set; }

        [Required(ErrorMessage = "*Termin Tarihi boş bırakılamaz!")]
        public string Deadline { get; set; }

        public bool status { get; set; } = true;

        public string? Description { get; set; }

        public string? PhotoPath { get; set; }


        //Order Dist

        private int _s28;
        public int s28
        {
            get { 
                if (_s28 == null)
                {
                    return 0;
                }
                else{
                    return _s28;
                }
             }
            set { _s28 = value; }
        }

        private int _s30;
        public int s30
        {
            get { 
                if (_s30 == null)
                {
                    return 0;
                }
                else{
                    return _s30;
                }
             }
            set { _s30 = value; }
        }

        private int _s32;
        public int s32
        {
            get { 
                if (_s32 == null)
                {
                    return 0;
                }
                else{
                    return _s32;
                }
             }
            set { _s32 = value; }
        }

        private int _s34;
        public int s34
        {
            get { 
                if (_s34 == null)
                {
                    return 0;
                }
                else{
                    return _s34;
                }
             }
            set { _s34 = value; }
        }

        private int _s36;
        public int s36
        {
            get { 
                if (_s36 == null)
                {
                    return 0;
                }
                else{
                    return _s36;
                }
             }
            set { _s36 = value; }
        }

        private int _s38;
        public int s38
        {
            get { 
                if (_s38 == null)
                {
                    return 0;
                }
                else{
                    return _s38;
                }
             }
            set { _s38 = value; }
        }

        private int _s40;
        public int s40
        {
            get { 
                if (_s40 == null)
                {
                    return 0;
                }
                else{
                    return _s40;
                }
             }
            set { _s40 = value; }
        }

        private int _s42;
        public int s42
        {
            get { 
                if (_s42 == null)
                {
                    return 0;
                }
                else{
                    return _s42;
                }
             }
            set { _s42 = value; }
        }

        private int _s44;
        public int s44
        {
            get { 
                if (_s44 == null)
                {
                    return 0;
                }
                else{
                    return _s44;
                }
             }
            set { _s44 = value; }
        }

        private int _s46;
        public int s46
        {
            get { 
                if (_s46 == null)
                {
                    return 0;
                }
                else{
                    return _s46;
                }
             }
            set { _s46 = value; }
        }

        private int _s48;
        public int s48
        {
            get { 
                if (_s48 == null)
                {
                    return 0;
                }
                else{
                    return _s48;
                }
             }
            set { _s48 = value; }
        }

        private int _s50;
        public int s50
        {
            get { 
                if (_s50 == null)
                {
                    return 0;
                }
                else{
                    return _s50;
                }
             }
            set { _s50 = value; }
        }

        public int? sCount { get; set; }


        //Cut Dist
        private int _k28;
        public int k28
        {
            get { 
                if (_k28 == null)
                {
                    return 0;
                }
                else{
                    return _k28;
                }
             }
            set { _k28 = value; }
        }

        private int _k30;
        public int k30
        {
            get { 
                if (_k30 == null)
                {
                    return 0;
                }
                else{
                    return _k30;
                }
             }
            set { _k30 = value; }
        }

        private int _k32;
        public int k32
        {
            get { 
                if (_k32 == null)
                {
                    return 0;
                }
                else{
                    return _k32;
                }
             }
            set { _k32 = value; }
        }

        private int _k34;
        public int k34
        {
            get { 
                if (_k34 == null)
                {
                    return 0;
                }
                else{
                    return _k34;
                }
             }
            set { _k34 = value; }
        }

        private int _k36;
        public int k36
        {
            get { 
                if (_k36 == null)
                {
                    return 0;
                }
                else{
                    return _k36;
                }
             }
            set { _k36 = value; }
        }

        private int _k38;
        public int k38
        {
            get { 
                if (_k38 == null)
                {
                    return 0;
                }
                else{
                    return _k38;
                }
             }
            set { _k38 = value; }
        }

        private int _k40;
        public int k40
        {
            get { 
                if (_k40 == null)
                {
                    return 0;
                }
                else{
                    return _k40;
                }
             }
            set { _k40 = value; }
        }

        private int _k42;
        public int k42
        {
            get { 
                if (_k42 == null)
                {
                    return 0;
                }
                else{
                    return _k42;
                }
             }
            set { _k42 = value; }
        }

        private int _k44;
        public int k44
        {
            get { 
                if (_k44 == null)
                {
                    return 0;
                }
                else{
                    return _k44;
                }
             }
            set { _k44 = value; }
        }

        private int _k46;
        public int k46
        {
            get { 
                if (_k46 == null)
                {
                    return 0;
                }
                else{
                    return _k46;
                }
             }
            set { _k46 = value; }
        }

        private int _k48;
        public int k48
        {
            get { 
                if (_k48 == null)
                {
                    return 0;
                }
                else{
                    return _k48;
                }
             }
            set { _k48 = value; }
        }

        private int _k50;
        public int k50
        {
            get { 
                if (_k50 == null)
                {
                    return 0;
                }
                else{
                    return _k50;
                }
             }
            set { _k50 = value; }
        }

        public int? kCount { get; set; }

    }
}