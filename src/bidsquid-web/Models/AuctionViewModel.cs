using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace bidsquid_web.Models
{
    public class AuctionViewModel
    {
        private readonly List<AuctionItem> _items = new List<AuctionItem>();

        public DateTime Date { get; }

        public string TagLine { get; }

        public IEnumerable<AuctionItem> Items { get { return _items; } }

        public AuctionViewModel(DateTime date, string tagLine)
        {
            Date = date;
            TagLine = tagLine;
        }

        public Task AddItemAsync(string itemTitle, CancellationToken cancellationToken = default(CancellationToken))
        {
            _items.Add(new AuctionItem(itemTitle, 0m));
            return Task.CompletedTask;
        }
    }

    public class AuctionItem : IEquatable<AuctionItem>
    {
        public AuctionItem(string title, decimal estimatedValue)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("message", nameof(title));
            }

            Title = title;
            EstimatedValue = estimatedValue;
        }

        public string Title { get; }
        public decimal EstimatedValue { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as AuctionItem);
        }

        public bool Equals(AuctionItem other)
        {
            return other != null &&
                   Title == other.Title &&
                   EstimatedValue == other.EstimatedValue;
        }

        public override int GetHashCode()
        {
            var hashCode = 1823031399;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EstimatedValue.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(AuctionItem item1, AuctionItem item2)
        {
            return EqualityComparer<AuctionItem>.Default.Equals(item1, item2);
        }

        public static bool operator !=(AuctionItem item1, AuctionItem item2)
        {
            return !(item1 == item2);
        }
    }
}
