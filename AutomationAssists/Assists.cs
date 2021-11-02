using System.Windows;

namespace AutomationAssists
{
    public class Assists
    {
        public static bool GetCanAutomationed(DependencyObject obj)
        {
            return (bool)obj.GetValue(CanAutomationedProperty);
        }

        public static void SetCanAutomationed(DependencyObject obj, bool value)
        {
            obj.SetValue(CanAutomationedProperty, value);
        }

        // Using a DependencyProperty as the backing store for CanAutomationed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanAutomationedProperty =
            DependencyProperty.RegisterAttached("CanAutomationed", typeof(bool), typeof(Assists), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.Inherits,OnCanAutomationedChanged));

        public static void OnCanAutomationedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement element)
            {
                if ((bool)e.NewValue)
                {
                    var hasAutomationPeer = typeof(UIElement).GetProperty("HasAutomationPeer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    hasAutomationPeer.SetValue(element, false);
                    var methond = typeof(UIElement).GetMethod("CreateAutomationPeer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    var peer = methond.Invoke(element, null);
                }
                else
                {
                    var hasAutomationPeer = typeof(UIElement).GetProperty("HasAutomationPeer", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    hasAutomationPeer.SetValue(element, true);
                    var field = typeof(UIElement).GetField("AutomationPeerField", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                    var automationPeerFieldValue = field.GetValue(element);
                    var gMethod = automationPeerFieldValue.GetType().GetMethod("ClearValue");
                    gMethod.Invoke(automationPeerFieldValue, new object[] { element });
                }
            }

        }
    }
}
