﻿namespace ImageNet.Core.Filtering.Hsls
{
    public class HslFiltersImpl : IHslFilters
    {
        public IFilter Brightness(int luminance)
        {
            return new BrightnessFilter(luminance);
        }

        public IFilter Contrast(sbyte factor)
        {
            return new ContrastFilter(factor);
        }

        public IFilter Hue(int hue)
        {
            return new HueModifierFilter(hue);
        }

        public IFilter Saturation(float saturation)
        {
            return new SaturationFilter(saturation);
        }
    }
}
