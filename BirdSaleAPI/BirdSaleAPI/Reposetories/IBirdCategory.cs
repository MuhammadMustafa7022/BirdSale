using BirdSaleAPI.DTOs;

namespace BirdSaleAPI.Reposetories
{
    public interface IBirdCategory
    {
        public Task<ResponseDTO> GetCategory();
        public Task<ResponseDTO> AddCategory(BirdCategoryDTO categoryDTO);
        public Task<ResponseDTO> DeleteCategory(int id);
        public Task<ResponseDTO> UpdateCategory(BirdCategoryDTO categoryDTO);
    }
}
