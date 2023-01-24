using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category)
            : base(success, message)
        {
            Category = category;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        public SaveCategoryResponse(Category category)
            : this(true, string.Empty, category) { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        public SaveCategoryResponse(string message)
            : this(false, message, null) { }
    }
}
