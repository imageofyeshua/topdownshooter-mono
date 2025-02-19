#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
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
  public float speed;

  public Hero(string Path, Vector2 Pos, Vector2 Dims)
      : base(Path, Pos, Dims)
  {
    speed = 2.0f;
  }

  public override void Update()
  {
    if (Globals.keyboard.GetPress("A"))
    {
      pos = new Vector2(pos.X - speed, pos.Y);
    }
    if (Globals.keyboard.GetPress("D"))
    {
      pos = new Vector2(pos.X + speed, pos.Y);
    }
    if (Globals.keyboard.GetPress("W"))
    {
      pos = new Vector2(pos.X, pos.Y - speed);
    }
    if (Globals.keyboard.GetPress("S"))
    {
      pos = new Vector2(pos.X, pos.Y + speed);
    }

    rot = Globals.RotateTowards(
        pos,
        new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y)
    );

    base.Update();
  }

  public override void Draw(Vector2 Offset)
  {
    base.Draw(Offset);
  }
}
