# miniclock
A really tink Numeric clock for windows 

## 下载
进入这里下载最新版 → [release](https://github.com/kasusa/miniclock/releases) 

## 软件的介绍
你是一个windows使用者, 你喜欢把你的任务栏隐藏起来，但是你又需要时不时的看看时间。
or 你喜欢玩游戏,但是某些游戏的gui不自带时间显示(可以配合Borderless Gaming一起使用)

这个软件可以在你的屏幕上显示时间，左上角或者右上角任你选择。

> 我最开始是在玩守望先锋的时候，在设置里面可以调出一个很小时间显示器。这就是我的灵感来源，虽然我做的没有它的好看。如果真的要做到那种样子大概需要自己写GUI而不是使用winform。

## 截图

![image.png](http://ww1.sinaimg.cn/large/006rgJELly1ghdvr0tb0pj301b00i0sh.jpg)
![image.png](http://ww1.sinaimg.cn/large/006rgJELly1ghdvs2l7faj301b00i0qt.jpg)
![image.png](http://ww1.sinaimg.cn/large/006rgJELly1ghdvsg8qdlj301b00i0ql.jpg)
![image.png](http://ww1.sinaimg.cn/large/006rgJELly1ghdvssp91bj301b00i0qi.jpg)

## 当前的问题
* 在亮色模式使用暗色模式的主题的文字颜色（theme）的话，文字看起来很不清晰（文字颜色太亮了）。

## 更新日志
### 2021-1-9

* 增加了宽度调节功能（经过我的测试，发现在不同分辨率，缩放比例下显示的时候有时时间文字会显示不全，所以增加了这个功能）
* 修复了hacker_style的有时候按钮有用，有时候没有用的bug（之前的代码逻辑有点问题）

### 2020-10-10

* 自动保存--现在保存是在更改的时候触发而不是退出的时候(这样有时候关机前没有关闭程序,之前的设置也可以保存了)
* 为了更加不混乱的 Alt-Tab 菜单,让其不在 Alt-Tab 菜单中显示

### 2020-9-20   

* 增加了按钮快捷键(右键miniclock,出现菜单后按快捷键[有下划线标记])
* 保证了颜色不会重复(取消了随机,现在是顺序播放颜色)
### 未来
* 自定义主题
* 更好的半透明主题(现在虽然也可以半透明但是最后的效果都很难看)

