using MinTur.BusinessLogicInterface.ResourceManagers;
using MinTur.DataAccessInterface.Facades;
using MinTur.Domain.BusinessEntities;
using System;

namespace MinTur.BusinessLogic.ResourceManagers
{
    public class ReviewManager : IReviewManager
    {
        private readonly IRepositoryFacade _repositoryFacade;

        public ReviewManager(IRepositoryFacade repositoryFacade)
        {
            _repositoryFacade = repositoryFacade;
        }

        public Review RegisterReview(Guid reservationId, Review review)
        {
            CheckReviewIsNotEmpty(review);

            Reservation retrievedReservation = _repositoryFacade.GetReservationById(reservationId);
            Resort relatedResort = _repositoryFacade.GetResortById(retrievedReservation.Resort.Id);

            review.Name = retrievedReservation.Name;
            review.Surname = retrievedReservation.Surname;
            review.ResortId = relatedResort.Id;
            review.ReservationId = retrievedReservation.Id;
            review.ValidOrFail();
            relatedResort.UpdateResortPunctuation(review);

            _repositoryFacade.UpdateResort(relatedResort);
            int newReviewId = _repositoryFacade.StoreReview(review);

            return _repositoryFacade.GetReviewById(newReviewId);
        }

        private static void CheckReviewIsNotEmpty(Review review)
        {
            if (ReviewIsEmpty(review))
            {
                throw new InvalidOperationException("Review is empty");
            }
        }

        private static bool ReviewIsEmpty(Review review)
        {
            return review.Text == "" || review.Text == null;
        }
    }
}
