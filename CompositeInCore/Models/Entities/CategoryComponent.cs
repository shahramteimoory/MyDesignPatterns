namespace CompositeInCore.Models.Entities
{
    public abstract class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string Print()
        {
            throw new NotSupportedException();
        }
        public abstract void Add(CategoryComponent component);
        public abstract void Remove(CategoryComponent component);
    }
    public class Category: CategoryComponent
    {
        readonly List<CategoryComponent> _menucomponents=new List<CategoryComponent>();

        public ICollection<CategoryComponent> MenuComponents => _menucomponents;
        public Category(string name)
        {
            Name = name;
        }
        public Category()
        {
            //ino mizarim ke Ef gir nade betoone migrate kone    
        }

        public override void Add(CategoryComponent component)
        {
            _menucomponents.Add(component);
        }

        public override void Remove(CategoryComponent component)
        {
            _menucomponents.Remove(component);
        }
        public override string Print()
        {
            string ul = $@"<ul> {Name}";
            foreach (var item in _menucomponents)
            {
                ul += item.Print();
            }
            ul += @$"</ul>";
            return ul;
        }

    }
    public class CategoryItem : CategoryComponent
    {
        public string Link { get; set; }
        public CategoryItem(string name,string link)
        {
            Name=name;
            Link=link;
        }
        public CategoryItem()
        {
            
        }
        public override void Add(CategoryComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryComponent component)
        {
            throw new NotImplementedException();
        }
        public override string Print()
        {
            string li = @$"<li> <a href='{Link}'> {Name} </a> </li>";
            return li;
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryItem categoryItem { get; set; }
        public int categoryItemId { get; set; }

    }
}
