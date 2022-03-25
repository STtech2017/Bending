using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_tech_Bending__CAD__CAM_
{
    public class ShapeView
    {
        public string id { get; set; }
        public string shapeName { get; set; }
        public string shapeType { get; set; }
        public int labelCount { get; set; }
        public int textBoxCount { get; set; }
        public IList<dynamicLabel> labels;
        public IList<dynamicTextBox> textBoxs;

    }
    public class dynamicLabel
    {
        public string labelName { get; set; }
        public string labelText { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int heigth { get; set; }
        public int width { get; set; }
    }
    public class dynamicTextBox
    {
        public string textBoxName { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int heigth { get; set; }
        public int width { get; set; }
    }

}
