using System.ComponentModel;

namespace TestCarouselView;

public partial class MainPage : ContentPage
{
    private readonly IReadOnlyList<string> _imageSource1 = new List<string>
    {
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/440022s.jpg",
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/440022s2.jpg",
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/440022s3.jpg",
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/440022s4.jpg",
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/440022s5.jpg"
    };
    private readonly IReadOnlyList<string> _imageSource2 = new List<string>() 
    { 
        "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemZoom/K92259s.jpg",
        "https://xcdn.next.co.uk/common/Items/Default/Default/ItemImages/AltItemZoom/K92259s2.jpg",
        "https://xcdn.next.co.uk/common/Items/Default/Default/ItemImages/AltItemZoom/K92259s3.jpg",
        "https://xcdn.next.co.uk/common/Items/Default/Default/ItemImages/AltItemZoom/K92259s4.jpg",
        "https://xcdn.next.co.uk/common/Items/Default/Default/ItemImages/AltItemZoom/K92259s5.jpg",
        "https://xcdn.next.co.uk/common/Items/Default/Default/ItemImages/AltItemZoom/K92259s6.jpg"
    };
    private IReadOnlyList<string> _images = [];
    public IReadOnlyList<string> Images
    {
        get => _images;
        set
        {
            if (Equals(value, _images)) return;
            _images = value;
            OnPropertyChanged();
        }
    }
    
    public MainPage()
    {
        InitializeComponent();
        Images = _imageSource1;
    }

    private void OnChangeSourceClicked(object sender, EventArgs e)
    {
        if (Images?.Count == 6)
        {
            Images = _imageSource1;
        }
        else
        {
            Images = _imageSource2;
        }
    }
}