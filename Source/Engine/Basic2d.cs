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

public class Basic2d
{
  public float rot;

  public Vector2 pos,
         dims;

  public Texture2D myModel;

  public Basic2d(string Path, Vector2 Pos, Vector2 Dims)
  {
    pos = Pos;
    dims = Dims;

    myModel = Globals.content.Load<Texture2D>(Path);
  }

  public virtual void Update() { }

  public virtual void Draw(Vector2 Offset)
  {
    if (myModel != null)
    {
      Globals.spriteBatch.Draw(
          myModel,
          new Rectangle((int)(pos.X + Offset.X), (int)(pos.Y + Offset.Y), (int)dims.X, (int)dims.Y),
          null,
          Color.White,
          rot,
          new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2),
          new SpriteEffects(),
          0
          );
    }
  }

  public virtual void Draw(Vector2 Offset, Vector2 Origin)
  {
    if (myModel != null)
    {
      Globals.spriteBatch.Draw(
          myModel,
          new Rectangle((int)(pos.X + Offset.X), (int)(pos.Y + Offset.Y), (int)dims.X, (int)dims.Y),
          null,
          Color.White,
          rot,
          new Vector2(Origin.X, Origin.Y),
          new SpriteEffects(),
          0
          );
    }
  }
}
