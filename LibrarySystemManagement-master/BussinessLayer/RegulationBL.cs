using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
namespace BussinessLayer
{
    public  class RegulationBL
    {
        private RegulationDL regulationDL=new RegulationDL();
        public List<Regulation> GetRegulations()
        {
            return regulationDL.GetAllRegulations();
        }
        public RegulationBL()
        {
        }
        



        // Cập nhật mô tả quy định
        public bool UpdateDescription(int re_Id, string newDescription)
        {
            // Kiểm tra nghiệp vụ (ví dụ: không để mô tả trống)
            if (string.IsNullOrWhiteSpace(newDescription))
                throw new ArgumentException("Mô tả không được để trống.");

            return regulationDL.UpdateDescription(re_Id, newDescription);
        }

        // Cập nhật số ngày mượn tối đa
        public bool UpdateMaxBookDays(int re_Id, int newMaxBookDays)
        {
            if (newMaxBookDays <= 0)
                throw new ArgumentException("Số ngày mượn phải lớn hơn 0.");

            return regulationDL.UpdateMaxBookDays(re_Id, newMaxBookDays);
        }

        // Cập nhật tiền phạt mỗi ngày
        public bool UpdateFinePerDays(int re_Id, int newFinePerDays)
        {
            if (newFinePerDays < 0)
                throw new ArgumentException("Tiền phạt không được âm.");

            return regulationDL.UpdateFinePerDays(re_Id, newFinePerDays);
        }

        // Cập nhật số lượng sách được mượn tối đa
        public bool UpdateMaxBookAllow(int re_Id, int newMaxBookAllow)
        {
            if (newMaxBookAllow <= 0)
                throw new ArgumentException("Số lượng sách mượn tối đa phải lớn hơn 0.");

            return regulationDL.UpdateMaxBookAllow(re_Id, newMaxBookAllow);
        }
    }

}

