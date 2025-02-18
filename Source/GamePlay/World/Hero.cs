#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace TopDownShooter;

public class Hero : Basic2d
{
    public Hero(string Path, Vector2 Pos, Vector2 Dims) : base(Path, Pos, Dims)
    {
    }

    public override void Update()
    {
      if (Globals.keyboard.GetPress("A"))
      {
        pos = new Vector2(pos.X - 1, pos.Y);
      }
      if (Globals.keyboard.GetPress("D"))
      {
        pos = new Vector2(pos.X + 1, pos.Y);
      }
      if (Globals.keyboard.GetPress("W"))
      {
        pos = new Vector2(pos.X, pos.Y - 1);
      }
      if (Globals.keyboard.GetPress("S"))
      {
        pos = new Vector2(pos.X, pos.Y + 1);
      }
    }

    public override void Draw()
    {
        base.Draw();
    }

}
