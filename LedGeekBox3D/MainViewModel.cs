using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixToolkit.Wpf;

namespace LedGeekBox3D
{
    using System.Windows.Media;
    using System.Windows.Media.Media3D;



    /// <summary>
    /// Provides a ViewModel for the Main window.
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            // Create a model group
            var modelGroup = new Model3DGroup();

            // Create a mesh builder and add a box to it
            var meshBuilder = new MeshBuilder(false, false);
            meshBuilder.AddSphere(new Point3D(0, 0, 0), 0.5);

            // Create a mesh from the builder (and freeze it)
            var mesh = meshBuilder.ToMesh(true);
         

            var blueMaterial = MaterialHelper.CreateMaterial(Colors.Blue);
            var insideMaterial = MaterialHelper.CreateMaterial(Colors.Yellow);
            var greyMaterial = MaterialHelper.CreateMaterial(Colors.LightGray);

            List<TranslateTransform3D> transformations = GetAllSheres();


           transformations.ForEach(
                f =>
                    modelGroup.Children.Add(new GeometryModel3D
                    {
                        Geometry = mesh,
                        Transform = f,
                        Material = blueMaterial,
                        BackMaterial = insideMaterial
                    }));

            // Set the property, which will be bound to the Content property of the ModelVisual3D (see MainWindow.xaml)
            this.Model = modelGroup;
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public Model3D Model { get; set; }


        private static List<TranslateTransform3D> GetAllSheres()
        {

            List<TranslateTransform3D> transformations = new List<TranslateTransform3D>();

            //-12
            transformations.Add(new TranslateTransform3D(-12, -12, -12));
            transformations.Add(new TranslateTransform3D(-12, -12, -8));
            transformations.Add(new TranslateTransform3D(-12, -12, -4));
            transformations.Add(new TranslateTransform3D(-12, -12, 0));
            transformations.Add(new TranslateTransform3D(-12, -12, 4));
            transformations.Add(new TranslateTransform3D(-12, -12, 8));
            transformations.Add(new TranslateTransform3D(-12, -12, 12));
            transformations.Add(new TranslateTransform3D(-12, -12, 16));

            transformations.Add(new TranslateTransform3D(-12, -8, -12));
            transformations.Add(new TranslateTransform3D(-12, -8, -8));
            transformations.Add(new TranslateTransform3D(-12, -8, -4));
            transformations.Add(new TranslateTransform3D(-12, -8, 0));
            transformations.Add(new TranslateTransform3D(-12, -8, 4));
            transformations.Add(new TranslateTransform3D(-12, -8, 8));
            transformations.Add(new TranslateTransform3D(-12, -8, 12));
            transformations.Add(new TranslateTransform3D(-12, -8, 16));

            transformations.Add(new TranslateTransform3D(-12, -4, -12));
            transformations.Add(new TranslateTransform3D(-12, -4, -8));
            transformations.Add(new TranslateTransform3D(-12, -4, -4));
            transformations.Add(new TranslateTransform3D(-12, -4, 0));
            transformations.Add(new TranslateTransform3D(-12, -4, 4));
            transformations.Add(new TranslateTransform3D(-12, -4, 8));
            transformations.Add(new TranslateTransform3D(-12, -4, 12));
            transformations.Add(new TranslateTransform3D(-12, -4, 16));

            transformations.Add(new TranslateTransform3D(-12, 0, -12));
            transformations.Add(new TranslateTransform3D(-12, 0, -8));
            transformations.Add(new TranslateTransform3D(-12, 0, -4));
            transformations.Add(new TranslateTransform3D(-12, 0, 0));
            transformations.Add(new TranslateTransform3D(-12, 0, 4));
            transformations.Add(new TranslateTransform3D(-12, 0, 8));
            transformations.Add(new TranslateTransform3D(-12, 0, 12));
            transformations.Add(new TranslateTransform3D(-12, 0, 16));

            transformations.Add(new TranslateTransform3D(-12, 4, -12));
            transformations.Add(new TranslateTransform3D(-12, 4, -8));
            transformations.Add(new TranslateTransform3D(-12, 4, -4));
            transformations.Add(new TranslateTransform3D(-12, 4, 0));
            transformations.Add(new TranslateTransform3D(-12, 4, 4));
            transformations.Add(new TranslateTransform3D(-12, 4, 8));
            transformations.Add(new TranslateTransform3D(-12, 4, 12));
            transformations.Add(new TranslateTransform3D(-12, 4, 16));

            transformations.Add(new TranslateTransform3D(-12, 8, -12));
            transformations.Add(new TranslateTransform3D(-12, 8, -8));
            transformations.Add(new TranslateTransform3D(-12, 8, -4));
            transformations.Add(new TranslateTransform3D(-12, 8, 0));
            transformations.Add(new TranslateTransform3D(-12, 8, 4));
            transformations.Add(new TranslateTransform3D(-12, 8, 8));
            transformations.Add(new TranslateTransform3D(-12, 8, 12));
            transformations.Add(new TranslateTransform3D(-12, 8, 16));

            transformations.Add(new TranslateTransform3D(-12, 12, -12));
            transformations.Add(new TranslateTransform3D(-12, 12, -8));
            transformations.Add(new TranslateTransform3D(-12, 12, -4));
            transformations.Add(new TranslateTransform3D(-12, 12, 0));
            transformations.Add(new TranslateTransform3D(-12, 12, 4));
            transformations.Add(new TranslateTransform3D(-12, 12, 8));
            transformations.Add(new TranslateTransform3D(-12, 12, 12));
            transformations.Add(new TranslateTransform3D(-12, 12, 16));

            transformations.Add(new TranslateTransform3D(-12, 16, -12));
            transformations.Add(new TranslateTransform3D(-12, 16, -8));
            transformations.Add(new TranslateTransform3D(-12, 16, -4));
            transformations.Add(new TranslateTransform3D(-12, 16, 0));
            transformations.Add(new TranslateTransform3D(-12, 16, 4));
            transformations.Add(new TranslateTransform3D(-12, 16, 8));
            transformations.Add(new TranslateTransform3D(-12, 16, 12));
            transformations.Add(new TranslateTransform3D(-12, 16, 16));


            //-8
            transformations.Add(new TranslateTransform3D(-8, -12, -12));
            transformations.Add(new TranslateTransform3D(-8, -12, -8));
            transformations.Add(new TranslateTransform3D(-8, -12, -4));
            transformations.Add(new TranslateTransform3D(-8, -12, 0));
            transformations.Add(new TranslateTransform3D(-8, -12, 4));
            transformations.Add(new TranslateTransform3D(-8, -12, 8));
            transformations.Add(new TranslateTransform3D(-8, -12, 12));
            transformations.Add(new TranslateTransform3D(-8, -12, 16));

            transformations.Add(new TranslateTransform3D(-8, -8, -12));
            transformations.Add(new TranslateTransform3D(-8, -8, -8));
            transformations.Add(new TranslateTransform3D(-8, -8, -4));
            transformations.Add(new TranslateTransform3D(-8, -8, 0));
            transformations.Add(new TranslateTransform3D(-8, -8, 4));
            transformations.Add(new TranslateTransform3D(-8, -8, 8));
            transformations.Add(new TranslateTransform3D(-8, -8, 12));
            transformations.Add(new TranslateTransform3D(-8, -8, 16));

            transformations.Add(new TranslateTransform3D(-8, -4, -12));
            transformations.Add(new TranslateTransform3D(-8, -4, -8));
            transformations.Add(new TranslateTransform3D(-8, -4, -4));
            transformations.Add(new TranslateTransform3D(-8, -4, 0));
            transformations.Add(new TranslateTransform3D(-8, -4, 4));
            transformations.Add(new TranslateTransform3D(-8, -4, 8));
            transformations.Add(new TranslateTransform3D(-8, -4, 12));
            transformations.Add(new TranslateTransform3D(-8, -4, 16));

            transformations.Add(new TranslateTransform3D(-8, 0, -12));
            transformations.Add(new TranslateTransform3D(-8, 0, -8));
            transformations.Add(new TranslateTransform3D(-8, 0, -4));
            transformations.Add(new TranslateTransform3D(-8, 0, 0));
            transformations.Add(new TranslateTransform3D(-8, 0, 4));
            transformations.Add(new TranslateTransform3D(-8, 0, 8));
            transformations.Add(new TranslateTransform3D(-8, 0, 12));
            transformations.Add(new TranslateTransform3D(-8, 0, 16));

            transformations.Add(new TranslateTransform3D(-8, 4, -12));
            transformations.Add(new TranslateTransform3D(-8, 4, -8));
            transformations.Add(new TranslateTransform3D(-8, 4, -4));
            transformations.Add(new TranslateTransform3D(-8, 4, 0));
            transformations.Add(new TranslateTransform3D(-8, 4, 4));
            transformations.Add(new TranslateTransform3D(-8, 4, 8));
            transformations.Add(new TranslateTransform3D(-8, 4, 12));
            transformations.Add(new TranslateTransform3D(-8, 4, 16));

            transformations.Add(new TranslateTransform3D(-8, 8, -12));
            transformations.Add(new TranslateTransform3D(-8, 8, -8));
            transformations.Add(new TranslateTransform3D(-8, 8, -4));
            transformations.Add(new TranslateTransform3D(-8, 8, 0));
            transformations.Add(new TranslateTransform3D(-8, 8, 4));
            transformations.Add(new TranslateTransform3D(-8, 8, 8));
            transformations.Add(new TranslateTransform3D(-8, 8, 12));
            transformations.Add(new TranslateTransform3D(-8, 8, 16));

            transformations.Add(new TranslateTransform3D(-8, 12, -12));
            transformations.Add(new TranslateTransform3D(-8, 12, -8));
            transformations.Add(new TranslateTransform3D(-8, 12, -4));
            transformations.Add(new TranslateTransform3D(-8, 12, 0));
            transformations.Add(new TranslateTransform3D(-8, 12, 4));
            transformations.Add(new TranslateTransform3D(-8, 12, 8));
            transformations.Add(new TranslateTransform3D(-8, 12, 12));
            transformations.Add(new TranslateTransform3D(-8, 12, 16));

            transformations.Add(new TranslateTransform3D(-8, 16, -12));
            transformations.Add(new TranslateTransform3D(-8, 16, -8));
            transformations.Add(new TranslateTransform3D(-8, 16, -4));
            transformations.Add(new TranslateTransform3D(-8, 16, 0));
            transformations.Add(new TranslateTransform3D(-8, 16, 4));
            transformations.Add(new TranslateTransform3D(-8, 16, 8));
            transformations.Add(new TranslateTransform3D(-8, 16, 12));
            transformations.Add(new TranslateTransform3D(-8, 16, 16));


            //-4
            transformations.Add(new TranslateTransform3D(-4, -12, -12));
            transformations.Add(new TranslateTransform3D(-4, -12, -8));
            transformations.Add(new TranslateTransform3D(-4, -12, -4));
            transformations.Add(new TranslateTransform3D(-4, -12, 0));
            transformations.Add(new TranslateTransform3D(-4, -12, 4));
            transformations.Add(new TranslateTransform3D(-4, -12, 8));
            transformations.Add(new TranslateTransform3D(-4, -12, 12));
            transformations.Add(new TranslateTransform3D(-4, -12, 16));

            transformations.Add(new TranslateTransform3D(-4, -8, -12));
            transformations.Add(new TranslateTransform3D(-4, -8, -8));
            transformations.Add(new TranslateTransform3D(-4, -8, -4));
            transformations.Add(new TranslateTransform3D(-4, -8, 0));
            transformations.Add(new TranslateTransform3D(-4, -8, 4));
            transformations.Add(new TranslateTransform3D(-4, -8, 8));
            transformations.Add(new TranslateTransform3D(-4, -8, 12));
            transformations.Add(new TranslateTransform3D(-4, -8, 16));

            transformations.Add(new TranslateTransform3D(-4, -4, -12));
            transformations.Add(new TranslateTransform3D(-4, -4, -8));
            transformations.Add(new TranslateTransform3D(-4, -4, -4));
            transformations.Add(new TranslateTransform3D(-4, -4, 0));
            transformations.Add(new TranslateTransform3D(-4, -4, 4));
            transformations.Add(new TranslateTransform3D(-4, -4, 8));
            transformations.Add(new TranslateTransform3D(-4, -4, 12));
            transformations.Add(new TranslateTransform3D(-4, -4, 16));

            transformations.Add(new TranslateTransform3D(-4, 0, -12));
            transformations.Add(new TranslateTransform3D(-4, 0, -8));
            transformations.Add(new TranslateTransform3D(-4, 0, -4));
            transformations.Add(new TranslateTransform3D(-4, 0, 0));
            transformations.Add(new TranslateTransform3D(-4, 0, 4));
            transformations.Add(new TranslateTransform3D(-4, 0, 8));
            transformations.Add(new TranslateTransform3D(-4, 0, 12));
            transformations.Add(new TranslateTransform3D(-4, 0, 16));

            transformations.Add(new TranslateTransform3D(-4, 4, -12));
            transformations.Add(new TranslateTransform3D(-4, 4, -8));
            transformations.Add(new TranslateTransform3D(-4, 4, -4));
            transformations.Add(new TranslateTransform3D(-4, 4, 0));
            transformations.Add(new TranslateTransform3D(-4, 4, 4));
            transformations.Add(new TranslateTransform3D(-4, 4, 8));
            transformations.Add(new TranslateTransform3D(-4, 4, 12));
            transformations.Add(new TranslateTransform3D(-4, 4, 16));

            transformations.Add(new TranslateTransform3D(-4, 8, -12));
            transformations.Add(new TranslateTransform3D(-4, 8, -8));
            transformations.Add(new TranslateTransform3D(-4, 8, -4));
            transformations.Add(new TranslateTransform3D(-4, 8, 0));
            transformations.Add(new TranslateTransform3D(-4, 8, 4));
            transformations.Add(new TranslateTransform3D(-4, 8, 8));
            transformations.Add(new TranslateTransform3D(-4, 8, 12));
            transformations.Add(new TranslateTransform3D(-4, 8, 16));

            transformations.Add(new TranslateTransform3D(-4, 12, -12));
            transformations.Add(new TranslateTransform3D(-4, 12, -8));
            transformations.Add(new TranslateTransform3D(-4, 12, -4));
            transformations.Add(new TranslateTransform3D(-4, 12, 0));
            transformations.Add(new TranslateTransform3D(-4, 12, 4));
            transformations.Add(new TranslateTransform3D(-4, 12, 8));
            transformations.Add(new TranslateTransform3D(-4, 12, 12));
            transformations.Add(new TranslateTransform3D(-4, 12, 16));

            transformations.Add(new TranslateTransform3D(-4, 16, -12));
            transformations.Add(new TranslateTransform3D(-4, 16, -8));
            transformations.Add(new TranslateTransform3D(-4, 16, -4));
            transformations.Add(new TranslateTransform3D(-4, 16, 0));
            transformations.Add(new TranslateTransform3D(-4, 16, 4));
            transformations.Add(new TranslateTransform3D(-4, 16, 8));
            transformations.Add(new TranslateTransform3D(-4, 16, 12));
            transformations.Add(new TranslateTransform3D(-4, 16, 16));


            //0
            transformations.Add(new TranslateTransform3D(0, -12, -12));
            transformations.Add(new TranslateTransform3D(0, -12, -8));
            transformations.Add(new TranslateTransform3D(0, -12, -4));
            transformations.Add(new TranslateTransform3D(0, -12, 0));
            transformations.Add(new TranslateTransform3D(0, -12, 4));
            transformations.Add(new TranslateTransform3D(0, -12, 8));
            transformations.Add(new TranslateTransform3D(0, -12, 12));
            transformations.Add(new TranslateTransform3D(0, -12, 16));

            transformations.Add(new TranslateTransform3D(0, -8, -12));
            transformations.Add(new TranslateTransform3D(0, -8, -8));
            transformations.Add(new TranslateTransform3D(0, -8, -4));
            transformations.Add(new TranslateTransform3D(0, -8, 0));
            transformations.Add(new TranslateTransform3D(0, -8, 4));
            transformations.Add(new TranslateTransform3D(0, -8, 8));
            transformations.Add(new TranslateTransform3D(0, -8, 12));
            transformations.Add(new TranslateTransform3D(0, -8, 16));

            transformations.Add(new TranslateTransform3D(0, -4, -12));
            transformations.Add(new TranslateTransform3D(0, -4, -8));
            transformations.Add(new TranslateTransform3D(0, -4, -4));
            transformations.Add(new TranslateTransform3D(0, -4, 0));
            transformations.Add(new TranslateTransform3D(0, -4, 4));
            transformations.Add(new TranslateTransform3D(0, -4, 8));
            transformations.Add(new TranslateTransform3D(0, -4, 12));
            transformations.Add(new TranslateTransform3D(0, -4, 16));

            transformations.Add(new TranslateTransform3D(0, 0, -12));
            transformations.Add(new TranslateTransform3D(0, 0, -8));
            transformations.Add(new TranslateTransform3D(0, 0, -4));
            transformations.Add(new TranslateTransform3D(0, 0, 0));
            transformations.Add(new TranslateTransform3D(0, 0, 4));
            transformations.Add(new TranslateTransform3D(0, 0, 8));
            transformations.Add(new TranslateTransform3D(0, 0, 12));
            transformations.Add(new TranslateTransform3D(0, 0, 16));

            transformations.Add(new TranslateTransform3D(0, 4, -12));
            transformations.Add(new TranslateTransform3D(0, 4, -8));
            transformations.Add(new TranslateTransform3D(0, 4, -4));
            transformations.Add(new TranslateTransform3D(0, 4, 0));
            transformations.Add(new TranslateTransform3D(0, 4, 4));
            transformations.Add(new TranslateTransform3D(0, 4, 8));
            transformations.Add(new TranslateTransform3D(0, 4, 12));
            transformations.Add(new TranslateTransform3D(0, 4, 16));

            transformations.Add(new TranslateTransform3D(0, 8, -12));
            transformations.Add(new TranslateTransform3D(0, 8, -8));
            transformations.Add(new TranslateTransform3D(0, 8, -4));
            transformations.Add(new TranslateTransform3D(0, 8, 0));
            transformations.Add(new TranslateTransform3D(0, 8, 4));
            transformations.Add(new TranslateTransform3D(0, 8, 8));
            transformations.Add(new TranslateTransform3D(0, 8, 12));
            transformations.Add(new TranslateTransform3D(0, 8, 16));

            transformations.Add(new TranslateTransform3D(0, 12, -12));
            transformations.Add(new TranslateTransform3D(0, 12, -8));
            transformations.Add(new TranslateTransform3D(0, 12, -4));
            transformations.Add(new TranslateTransform3D(0, 12, 0));
            transformations.Add(new TranslateTransform3D(0, 12, 4));
            transformations.Add(new TranslateTransform3D(0, 12, 8));
            transformations.Add(new TranslateTransform3D(0, 12, 12));
            transformations.Add(new TranslateTransform3D(0, 12, 16));

            transformations.Add(new TranslateTransform3D(0, 16, -12));
            transformations.Add(new TranslateTransform3D(0, 16, -8));
            transformations.Add(new TranslateTransform3D(0, 16, -4));
            transformations.Add(new TranslateTransform3D(0, 16, 0));
            transformations.Add(new TranslateTransform3D(0, 16, 4));
            transformations.Add(new TranslateTransform3D(0, 16, 8));
            transformations.Add(new TranslateTransform3D(0, 16, 12));
            transformations.Add(new TranslateTransform3D(0, 16, 16));



            //4
            transformations.Add(new TranslateTransform3D(4, -12, -12));
            transformations.Add(new TranslateTransform3D(4, -12, -8));
            transformations.Add(new TranslateTransform3D(4, -12, -4));
            transformations.Add(new TranslateTransform3D(4, -12, 0));
            transformations.Add(new TranslateTransform3D(4, -12, 4));
            transformations.Add(new TranslateTransform3D(4, -12, 8));
            transformations.Add(new TranslateTransform3D(4, -12, 12));
            transformations.Add(new TranslateTransform3D(4, -12, 16));

            transformations.Add(new TranslateTransform3D(4, -8, -12));
            transformations.Add(new TranslateTransform3D(4, -8, -8));
            transformations.Add(new TranslateTransform3D(4, -8, -4));
            transformations.Add(new TranslateTransform3D(4, -8, 0));
            transformations.Add(new TranslateTransform3D(4, -8, 4));
            transformations.Add(new TranslateTransform3D(4, -8, 8));
            transformations.Add(new TranslateTransform3D(4, -8, 12));
            transformations.Add(new TranslateTransform3D(4, -8, 16));

            transformations.Add(new TranslateTransform3D(4, -4, -12));
            transformations.Add(new TranslateTransform3D(4, -4, -8));
            transformations.Add(new TranslateTransform3D(4, -4, -4));
            transformations.Add(new TranslateTransform3D(4, -4, 0));
            transformations.Add(new TranslateTransform3D(4, -4, 4));
            transformations.Add(new TranslateTransform3D(4, -4, 8));
            transformations.Add(new TranslateTransform3D(4, -4, 12));
            transformations.Add(new TranslateTransform3D(4, -4, 16));

            transformations.Add(new TranslateTransform3D(4, 0, -12));
            transformations.Add(new TranslateTransform3D(4, 0, -8));
            transformations.Add(new TranslateTransform3D(4, 0, -4));
            transformations.Add(new TranslateTransform3D(4, 0, 0));
            transformations.Add(new TranslateTransform3D(4, 0, 4));
            transformations.Add(new TranslateTransform3D(4, 0, 8));
            transformations.Add(new TranslateTransform3D(4, 0, 12));
            transformations.Add(new TranslateTransform3D(4, 0, 16));

            transformations.Add(new TranslateTransform3D(4, 4, -12));
            transformations.Add(new TranslateTransform3D(4, 4, -8));
            transformations.Add(new TranslateTransform3D(4, 4, -4));
            transformations.Add(new TranslateTransform3D(4, 4, 0));
            transformations.Add(new TranslateTransform3D(4, 4, 4));
            transformations.Add(new TranslateTransform3D(4, 4, 8));
            transformations.Add(new TranslateTransform3D(4, 4, 12));
            transformations.Add(new TranslateTransform3D(4, 4, 16));

            transformations.Add(new TranslateTransform3D(4, 8, -12));
            transformations.Add(new TranslateTransform3D(4, 8, -8));
            transformations.Add(new TranslateTransform3D(4, 8, -4));
            transformations.Add(new TranslateTransform3D(4, 8, 0));
            transformations.Add(new TranslateTransform3D(4, 8, 4));
            transformations.Add(new TranslateTransform3D(4, 8, 8));
            transformations.Add(new TranslateTransform3D(4, 8, 12));
            transformations.Add(new TranslateTransform3D(4, 8, 16));

            transformations.Add(new TranslateTransform3D(4, 12, -12));
            transformations.Add(new TranslateTransform3D(4, 12, -8));
            transformations.Add(new TranslateTransform3D(4, 12, -4));
            transformations.Add(new TranslateTransform3D(4, 12, 0));
            transformations.Add(new TranslateTransform3D(4, 12, 4));
            transformations.Add(new TranslateTransform3D(4, 12, 8));
            transformations.Add(new TranslateTransform3D(4, 12, 12));
            transformations.Add(new TranslateTransform3D(4, 12, 16));

            transformations.Add(new TranslateTransform3D(4, 16, -12));
            transformations.Add(new TranslateTransform3D(4, 16, -8));
            transformations.Add(new TranslateTransform3D(4, 16, -4));
            transformations.Add(new TranslateTransform3D(4, 16, 0));
            transformations.Add(new TranslateTransform3D(4, 16, 4));
            transformations.Add(new TranslateTransform3D(4, 16, 8));
            transformations.Add(new TranslateTransform3D(4, 16, 12));
            transformations.Add(new TranslateTransform3D(4, 16, 16));


            //8
            transformations.Add(new TranslateTransform3D(8, -12, -12));
            transformations.Add(new TranslateTransform3D(8, -12, -8));
            transformations.Add(new TranslateTransform3D(8, -12, -4));
            transformations.Add(new TranslateTransform3D(8, -12, 0));
            transformations.Add(new TranslateTransform3D(8, -12, 4));
            transformations.Add(new TranslateTransform3D(8, -12, 8));
            transformations.Add(new TranslateTransform3D(8, -12, 12));
            transformations.Add(new TranslateTransform3D(8, -12, 16));

            transformations.Add(new TranslateTransform3D(8, -8, -12));
            transformations.Add(new TranslateTransform3D(8, -8, -8));
            transformations.Add(new TranslateTransform3D(8, -8, -4));
            transformations.Add(new TranslateTransform3D(8, -8, 0));
            transformations.Add(new TranslateTransform3D(8, -8, 4));
            transformations.Add(new TranslateTransform3D(8, -8, 8));
            transformations.Add(new TranslateTransform3D(8, -8, 12));
            transformations.Add(new TranslateTransform3D(8, -8, 16));

            transformations.Add(new TranslateTransform3D(8, -4, -12));
            transformations.Add(new TranslateTransform3D(8, -4, -8));
            transformations.Add(new TranslateTransform3D(8, -4, -4));
            transformations.Add(new TranslateTransform3D(8, -4, 0));
            transformations.Add(new TranslateTransform3D(8, -4, 4));
            transformations.Add(new TranslateTransform3D(8, -4, 8));
            transformations.Add(new TranslateTransform3D(8, -4, 12));
            transformations.Add(new TranslateTransform3D(8, -4, 16));

            transformations.Add(new TranslateTransform3D(8, 0, -12));
            transformations.Add(new TranslateTransform3D(8, 0, -8));
            transformations.Add(new TranslateTransform3D(8, 0, -4));
            transformations.Add(new TranslateTransform3D(8, 0, 0));
            transformations.Add(new TranslateTransform3D(8, 0, 4));
            transformations.Add(new TranslateTransform3D(8, 0, 8));
            transformations.Add(new TranslateTransform3D(8, 0, 12));
            transformations.Add(new TranslateTransform3D(8, 0, 16));

            transformations.Add(new TranslateTransform3D(8, 4, -12));
            transformations.Add(new TranslateTransform3D(8, 4, -8));
            transformations.Add(new TranslateTransform3D(8, 4, -4));
            transformations.Add(new TranslateTransform3D(8, 4, 0));
            transformations.Add(new TranslateTransform3D(8, 4, 4));
            transformations.Add(new TranslateTransform3D(8, 4, 8));
            transformations.Add(new TranslateTransform3D(8, 4, 12));
            transformations.Add(new TranslateTransform3D(8, 4, 16));

            transformations.Add(new TranslateTransform3D(8, 8, -12));
            transformations.Add(new TranslateTransform3D(8, 8, -8));
            transformations.Add(new TranslateTransform3D(8, 8, -4));
            transformations.Add(new TranslateTransform3D(8, 8, 0));
            transformations.Add(new TranslateTransform3D(8, 8, 4));
            transformations.Add(new TranslateTransform3D(8, 8, 8));
            transformations.Add(new TranslateTransform3D(8, 8, 12));
            transformations.Add(new TranslateTransform3D(8, 8, 16));

            transformations.Add(new TranslateTransform3D(8, 12, -12));
            transformations.Add(new TranslateTransform3D(8, 12, -8));
            transformations.Add(new TranslateTransform3D(8, 12, -4));
            transformations.Add(new TranslateTransform3D(8, 12, 0));
            transformations.Add(new TranslateTransform3D(8, 12, 4));
            transformations.Add(new TranslateTransform3D(8, 12, 8));
            transformations.Add(new TranslateTransform3D(8, 12, 12));
            transformations.Add(new TranslateTransform3D(8, 12, 16));

            transformations.Add(new TranslateTransform3D(8, 16, -12));
            transformations.Add(new TranslateTransform3D(8, 16, -8));
            transformations.Add(new TranslateTransform3D(8, 16, -4));
            transformations.Add(new TranslateTransform3D(8, 16, 0));
            transformations.Add(new TranslateTransform3D(8, 16, 4));
            transformations.Add(new TranslateTransform3D(8, 16, 8));
            transformations.Add(new TranslateTransform3D(8, 16, 12));
            transformations.Add(new TranslateTransform3D(8, 16, 16));

            //12
            transformations.Add(new TranslateTransform3D(12, -12, -12));
            transformations.Add(new TranslateTransform3D(12, -12, -8));
            transformations.Add(new TranslateTransform3D(12, -12, -4));
            transformations.Add(new TranslateTransform3D(12, -12, 0));
            transformations.Add(new TranslateTransform3D(12, -12, 4));
            transformations.Add(new TranslateTransform3D(12, -12, 8));
            transformations.Add(new TranslateTransform3D(12, -12, 12));
            transformations.Add(new TranslateTransform3D(12, -12, 16));

            transformations.Add(new TranslateTransform3D(12, -8, -12));
            transformations.Add(new TranslateTransform3D(12, -8, -8));
            transformations.Add(new TranslateTransform3D(12, -8, -4));
            transformations.Add(new TranslateTransform3D(12, -8, 0));
            transformations.Add(new TranslateTransform3D(12, -8, 4));
            transformations.Add(new TranslateTransform3D(12, -8, 8));
            transformations.Add(new TranslateTransform3D(12, -8, 12));
            transformations.Add(new TranslateTransform3D(12, -8, 16));

            transformations.Add(new TranslateTransform3D(12, -4, -12));
            transformations.Add(new TranslateTransform3D(12, -4, -8));
            transformations.Add(new TranslateTransform3D(12, -4, -4));
            transformations.Add(new TranslateTransform3D(12, -4, 0));
            transformations.Add(new TranslateTransform3D(12, -4, 4));
            transformations.Add(new TranslateTransform3D(12, -4, 8));
            transformations.Add(new TranslateTransform3D(12, -4, 12));
            transformations.Add(new TranslateTransform3D(12, -4, 16));

            transformations.Add(new TranslateTransform3D(12, 0, -12));
            transformations.Add(new TranslateTransform3D(12, 0, -8));
            transformations.Add(new TranslateTransform3D(12, 0, -4));
            transformations.Add(new TranslateTransform3D(12, 0, 0));
            transformations.Add(new TranslateTransform3D(12, 0, 4));
            transformations.Add(new TranslateTransform3D(12, 0, 8));
            transformations.Add(new TranslateTransform3D(12, 0, 12));
            transformations.Add(new TranslateTransform3D(12, 0, 16));

            transformations.Add(new TranslateTransform3D(12, 4, -12));
            transformations.Add(new TranslateTransform3D(12, 4, -8));
            transformations.Add(new TranslateTransform3D(12, 4, -4));
            transformations.Add(new TranslateTransform3D(12, 4, 0));
            transformations.Add(new TranslateTransform3D(12, 4, 4));
            transformations.Add(new TranslateTransform3D(12, 4, 8));
            transformations.Add(new TranslateTransform3D(12, 4, 12));
            transformations.Add(new TranslateTransform3D(12, 4, 16));

            transformations.Add(new TranslateTransform3D(12, 8, -12));
            transformations.Add(new TranslateTransform3D(12, 8, -8));
            transformations.Add(new TranslateTransform3D(12, 8, -4));
            transformations.Add(new TranslateTransform3D(12, 8, 0));
            transformations.Add(new TranslateTransform3D(12, 8, 4));
            transformations.Add(new TranslateTransform3D(12, 8, 8));
            transformations.Add(new TranslateTransform3D(12, 8, 12));
            transformations.Add(new TranslateTransform3D(12, 8, 16));

            transformations.Add(new TranslateTransform3D(12, 12, -12));
            transformations.Add(new TranslateTransform3D(12, 12, -8));
            transformations.Add(new TranslateTransform3D(12, 12, -4));
            transformations.Add(new TranslateTransform3D(12, 12, 0));
            transformations.Add(new TranslateTransform3D(12, 12, 4));
            transformations.Add(new TranslateTransform3D(12, 12, 8));
            transformations.Add(new TranslateTransform3D(12, 12, 12));
            transformations.Add(new TranslateTransform3D(12, 12, 16));

            transformations.Add(new TranslateTransform3D(12, 16, -12));
            transformations.Add(new TranslateTransform3D(12, 16, -8));
            transformations.Add(new TranslateTransform3D(12, 16, -4));
            transformations.Add(new TranslateTransform3D(12, 16, 0));
            transformations.Add(new TranslateTransform3D(12, 16, 4));
            transformations.Add(new TranslateTransform3D(12, 16, 8));
            transformations.Add(new TranslateTransform3D(12, 16, 12));
            transformations.Add(new TranslateTransform3D(12, 16, 16));


            //16
            transformations.Add(new TranslateTransform3D(16, -12, -12));
            transformations.Add(new TranslateTransform3D(16, -12, -8));
            transformations.Add(new TranslateTransform3D(16, -12, -4));
            transformations.Add(new TranslateTransform3D(16, -12, 0));
            transformations.Add(new TranslateTransform3D(16, -12, 4));
            transformations.Add(new TranslateTransform3D(16, -12, 8));
            transformations.Add(new TranslateTransform3D(16, -12, 12));
            transformations.Add(new TranslateTransform3D(16, -12, 16));

            transformations.Add(new TranslateTransform3D(16, -8, -12));
            transformations.Add(new TranslateTransform3D(16, -8, -8));
            transformations.Add(new TranslateTransform3D(16, -8, -4));
            transformations.Add(new TranslateTransform3D(16, -8, 0));
            transformations.Add(new TranslateTransform3D(16, -8, 4));
            transformations.Add(new TranslateTransform3D(16, -8, 8));
            transformations.Add(new TranslateTransform3D(16, -8, 12));
            transformations.Add(new TranslateTransform3D(16, -8, 16));

            transformations.Add(new TranslateTransform3D(16, -4, -12));
            transformations.Add(new TranslateTransform3D(16, -4, -8));
            transformations.Add(new TranslateTransform3D(16, -4, -4));
            transformations.Add(new TranslateTransform3D(16, -4, 0));
            transformations.Add(new TranslateTransform3D(16, -4, 4));
            transformations.Add(new TranslateTransform3D(16, -4, 8));
            transformations.Add(new TranslateTransform3D(16, -4, 12));
            transformations.Add(new TranslateTransform3D(16, -4, 16));

            transformations.Add(new TranslateTransform3D(16, 0, -12));
            transformations.Add(new TranslateTransform3D(16, 0, -8));
            transformations.Add(new TranslateTransform3D(16, 0, -4));
            transformations.Add(new TranslateTransform3D(16, 0, 0));
            transformations.Add(new TranslateTransform3D(16, 0, 4));
            transformations.Add(new TranslateTransform3D(16, 0, 8));
            transformations.Add(new TranslateTransform3D(16, 0, 12));
            transformations.Add(new TranslateTransform3D(16, 0, 16));

            transformations.Add(new TranslateTransform3D(16, 4, -12));
            transformations.Add(new TranslateTransform3D(16, 4, -8));
            transformations.Add(new TranslateTransform3D(16, 4, -4));
            transformations.Add(new TranslateTransform3D(16, 4, 0));
            transformations.Add(new TranslateTransform3D(16, 4, 4));
            transformations.Add(new TranslateTransform3D(16, 4, 8));
            transformations.Add(new TranslateTransform3D(16, 4, 12));
            transformations.Add(new TranslateTransform3D(16, 4, 16));

            transformations.Add(new TranslateTransform3D(16, 8, -12));
            transformations.Add(new TranslateTransform3D(16, 8, -8));
            transformations.Add(new TranslateTransform3D(16, 8, -4));
            transformations.Add(new TranslateTransform3D(16, 8, 0));
            transformations.Add(new TranslateTransform3D(16, 8, 4));
            transformations.Add(new TranslateTransform3D(16, 8, 8));
            transformations.Add(new TranslateTransform3D(16, 8, 12));
            transformations.Add(new TranslateTransform3D(16, 8, 16));

            transformations.Add(new TranslateTransform3D(16, 12, -12));
            transformations.Add(new TranslateTransform3D(16, 12, -8));
            transformations.Add(new TranslateTransform3D(16, 12, -4));
            transformations.Add(new TranslateTransform3D(16, 12, 0));
            transformations.Add(new TranslateTransform3D(16, 12, 4));
            transformations.Add(new TranslateTransform3D(16, 12, 8));
            transformations.Add(new TranslateTransform3D(16, 12, 12));
            transformations.Add(new TranslateTransform3D(16, 12, 16));

            transformations.Add(new TranslateTransform3D(16, 16, -12));
            transformations.Add(new TranslateTransform3D(16, 16, -8));
            transformations.Add(new TranslateTransform3D(16, 16, -4));
            transformations.Add(new TranslateTransform3D(16, 16, 0));
            transformations.Add(new TranslateTransform3D(16, 16, 4));
            transformations.Add(new TranslateTransform3D(16, 16, 8));
            transformations.Add(new TranslateTransform3D(16, 16, 12));
            transformations.Add(new TranslateTransform3D(16, 16, 16));

            return transformations;
        }

    }
}

