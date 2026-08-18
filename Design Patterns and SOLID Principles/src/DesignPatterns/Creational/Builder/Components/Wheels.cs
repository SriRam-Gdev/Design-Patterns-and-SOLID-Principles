namespace DesignPatterns.Creational.Builder.Components
{
    public class Wheels
    {
        private float _diameterInInches;

        public Wheels(float diameterInInches)
        {
            _diameterInInches = diameterInInches;
        }

        public float GetDiameterInInches()
        {
            return _diameterInInches;
        }
    }
}