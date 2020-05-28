## v9.0 Alpha 6

- Revamped control rendering. `ControlConsole` renderer now has a 2nd surface which only controls are rendered to. This way the control layer system can update independently of the actual console.
- Fixed bug in renderers which the renderer wasn't attached and detached from the object when added.
- `Cursor` is now a component.
- `Cursor` has a new property named `MouseClickReposition` which when `true` allows a mouse click on the host console to move the cursor.
- `Cursor` a lot of quality of life improvements.
- Removed `ISurfaceRenderData` and went back to normal `IScreenSurface` for renderers.
- ControlHost correctly checks the parent of the control when processing the mouse.
- ControlHost no longer listens to the tab button when a control indicates it handled input
- Textbox bug fixes (thanks Doctor Triagony).

## v9.0 Alpha 5

- Moved `SadConsole.Global` into the `GameHost`.
- Rewrote the UI control framework, removing the need for `ControlsConsole`. Any console can now add the `UI.ControlHost` component and support controls.
  - `ControlsConsole` still exists as a simple way to automatically add the `ControlHost`.
- Settings now expose the defaults for `UseKeyboard` and `UseMouse` for screen objects.