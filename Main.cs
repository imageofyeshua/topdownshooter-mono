using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TopDownShooter;

public class Main : Game
{
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  World world;

  Basic2d cursor;

  public Main()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    // IsMouseVisible = true;
  }

  protected override void Initialize()
  {
    // TODO: Add your initialization logic here

    base.Initialize();
  }

  protected override void LoadContent()
  {
    Globals.content = this.Content;
    Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

    // TODO: use this.Content to load your game content here

    cursor = new Basic2d("2d/Misc/CursorArrow", new Vector2(0, 0), new Vector2(28, 28));

    Globals.keyboard = new McKeyboard();
    Globals.mouse = new McMouseControl();

    world = new World();
  }

  protected override void UnloadContent()
  {
    // TODO: Unload any non ContentManager content here
  }

  protected override void Update(GameTime gameTime)
  {
    if (
        GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
        || Keyboard.GetState().IsKeyDown(Keys.Escape)
    )
      Exit();

    // TODO: Add your update logic here

    Globals.keyboard.Update();

    world.Update();

    Globals.keyboard.UpdateOld();

    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.CornflowerBlue);

    // TODO: Add your drawing code here

    Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);
    Globals.mouse.Update();

    world.Draw(Vector2.Zero);

    cursor.Draw(
        new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y),
        new Vector2(0, 0)
    );
    Globals.spriteBatch.End();
    Globals.mouse.UpdateOld();

    base.Draw(gameTime);
  }
}
