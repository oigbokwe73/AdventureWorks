using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class  AdventureWorksDataContext
    {

        public List<ProductReview> ProductReviewList()
        {
            var getProductReview = Execute<List<ProductReview>>(dal =>
            {
                var item = dal.ProductReview.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductReview;
        }

        public List<ProductReview> ProductReviewListAll()
        {
            var getProductReview = Execute<List<ProductReview>>(dal =>
            {
                var item = dal.ProductReview;
                return item.ToList();
            });
            return getProductReview;
        }

        public bool ProductReviewUpdate(ProductReview productreview)
        {
             return Execute<bool>(dal =>
            {
                ProductReview productreviewUpdate = dal.ProductReview.Where(x => x.ProductReviewID == productreview.ProductReviewID).FirstOrDefault();
                if (productreviewUpdate != null)
                {
				    productreviewUpdate.ProductReviewID=productreview.ProductReviewID;
productreviewUpdate.ProductID=productreview.ProductID;
productreviewUpdate.ReviewerName=productreview.ReviewerName;
productreviewUpdate.ReviewDate=productreview.ReviewDate;
productreviewUpdate.EmailAddress=productreview.EmailAddress;
productreviewUpdate.Rating=productreview.Rating;
productreviewUpdate.Comments=productreview.Comments;
productreviewUpdate.ModifiedDate=productreview.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductReviewAdd(ProductReview productreview)
        {
            return Execute<bool>(dal =>
            {
                ProductReview productreviewAdd = dal.ProductReview.Where(x => x.ProductReviewID == productreview.ProductReviewID).FirstOrDefault();
                if (productreviewAdd != null)
                {
                    dal.ProductReview.InsertOnSubmit(productreviewAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductReviewDelete(ProductReview productreview)
        {
            return Execute<bool>(dal =>
            {
                ProductReview productreviewDelete = dal.ProductReview.Where(x => x.ProductReviewID == productreview.ProductReviewID).FirstOrDefault();
                if (productreviewDelete != null)
                {
                    dal.ProductReview.DeleteOnSubmit(productreviewDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}
