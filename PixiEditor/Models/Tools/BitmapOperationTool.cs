﻿using PixiEditor.Models.DataHolders;
using PixiEditor.Models.Layers;
using PixiEditor.Models.Position;
using System.Windows.Media;

namespace PixiEditor.Models.Tools
{
    public abstract class BitmapOperationTool : Tool
    {
        public abstract LayerChange[] Use(Layer layer, Coordinates[] mouseMove, Color color);
        public bool RequiresPreviewLayer { get; set; }
        public bool UseDefaultUndoMethod { get; set; } = true;

    }
}
