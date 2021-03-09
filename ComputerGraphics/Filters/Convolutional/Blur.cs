namespace ComputerGraphics.Filters.Convolutional
{
    public class Blur : ConvolutionalFilter
    {
        protected override double[,] CalculateKernel()
        {
            kernel = new double[,]
            {
                {0.0, 0.2, 0.0,},
                {0.2, 0.2, 0.2,},
                {0.0, 0.2, 0.2,},
            };

            return kernel;
        }
    }
}