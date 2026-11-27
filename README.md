# 一键息屏

Windows 桌面小工具，双击 `ScreenOff.exe` 后等待约 700 毫秒并关闭显示器。移动鼠标或按键可重新点亮屏幕。这样就不用频繁按显示器的开关了。

## 文件

- `ScreenOff.exe`：可直接运行的 Windows 程序
- `ScreenOff.cs`：C# 源码
- `ScreenOff.ico`：程序图标

此程序通过 Windows `user32.dll` 的 `SendMessage` 发送显示器电源关闭消息，不需要安装程序或额外运行时配置。
