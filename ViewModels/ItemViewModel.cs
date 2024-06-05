using InventoryLab.Business.Models;
using InventoryLab.Class;
using System.Collections.ObjectModel;

namespace InventoryLab.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        #region Fields & Data
        public ObservableCollection<Item> ItemList { get; set; }
        #endregion

        #region Constructors
        public ItemViewModel() 
        {
            ItemList = new ObservableCollection<Item>();    
        }
        #endregion

        #region Methods
        #endregion

        #region Buttons
        #endregion
    }
}