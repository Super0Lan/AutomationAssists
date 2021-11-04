# AutomationAssists
控制WPF应用程序是否能被自动化技术检测</br>
使用介绍:</br>
https://blog.csdn.net/qq_29198233/article/details/121098967</br>
示例代码：
<pre>
<code>&lt;Window x:Class=&quot;WPFDemo.MainWindow&quot;
    xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
    xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
    xmlns:d=&quot;http://schemas.microsoft.com/expression/blend/2008&quot;
    xmlns:mc=&quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;
    xmlns:local=&quot;clr-namespace:WPFDemo&quot;
    xmlns:lan=&quot;https://schemas.lan.com/assists/automation&quot;
    mc:Ignorable=&quot;d&quot; 
    lan:Assists.CanAutomationed=&quot;{Binding ElementName=checkBox,Path=IsChecked}&quot;
    Title=&quot;MainWindow&quot; Height=&quot;450&quot; Width=&quot;800&quot;&gt;
    &lt;StackPanel &gt;
        &lt;CheckBox Width=&quot;150&quot; Height=&quot;30&quot; Content=&quot;是否打开自动化&quot; x:Name=&quot;checkBox&quot;&gt;&lt;/CheckBox&gt;
        &lt;Button Content=&quot;这是一个按钮&quot;&gt;&lt;/Button&gt;
        &lt;CheckBox Content=&quot;这是一个单选框&quot;&gt;&lt;/CheckBox&gt;
        &lt;TextBox Text=&quot;这是一个文本输入框&quot;&gt;&lt;/TextBox&gt;
    &lt;/StackPanel&gt;
&lt;/Window&gt;</code>
</pre>
示例展示：</br>
<img src="https://img-blog.csdnimg.cn/0fb0da9128774bb290069ff5624722d7.gif" width="500">
