﻿#pragma checksum "C:\UWPprojects\FlightLines\App15\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E41110B182834D3465EF3839F19FA254"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App15
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Maps_MapControl_Layers(global::Windows.UI.Xaml.Controls.Maps.MapControl obj, global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapLayer> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapLayer>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapLayer>), targetNullValue);
                }
                obj.Layers = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::App15.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Maps.MapControl obj3;
            private global::Windows.UI.Xaml.Controls.Button obj4;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj10;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // MainPage.xaml line 19
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)target;
                        break;
                    case 4: // MainPage.xaml line 31
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 6: // MainPage.xaml line 34
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 10: // MainPage.xaml line 26
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App15.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App15.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::App15.LinesViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_MapLinesLayer(obj.MapLinesLayer, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LoadLinesCommand(obj.LoadLinesCommand, phase);
                        this.Update_ViewModel_ClearLinesCommand(obj.ClearLinesCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsWaiting(obj.IsWaiting, phase);
                    }
                }
            }
            private void Update_ViewModel_MapLinesLayer(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_MapLinesLayer(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Maps_MapControl_Layers(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_LoadLinesCommand(global::App15.RelayCommand<global::System.String> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 31
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_ClearLinesCommand(global::App15.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 34
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel_IsWaiting(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 26
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj10, obj);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_MapLinesLayer(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::App15.LinesViewModel obj = sender as global::App15.LinesViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_MapLinesLayer(obj.MapLinesLayer, DATA_CHANGED);
                                bindings.Update_ViewModel_IsWaiting(obj.IsWaiting, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "MapLinesLayer":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_MapLinesLayer(obj.MapLinesLayer, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsWaiting":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsWaiting(obj.IsWaiting, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::App15.LinesViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::App15.LinesViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_MapLinesLayer(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_MapLinesLayer(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer> cache_ViewModel_MapLinesLayer = null;
                public void UpdateChildListeners_ViewModel_MapLinesLayer(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Maps.MapLayer> obj)
                {
                    if (obj != cache_ViewModel_MapLinesLayer)
                    {
                        if (cache_ViewModel_MapLinesLayer != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_MapLinesLayer).PropertyChanged -= PropertyChanged_ViewModel_MapLinesLayer;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_MapLinesLayer).CollectionChanged -= CollectionChanged_ViewModel_MapLinesLayer;
                            cache_ViewModel_MapLinesLayer = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_MapLinesLayer = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_MapLinesLayer;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_MapLinesLayer;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.pageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 19
                {
                    this.map = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.map).Loaded += this.mapLoaded;
                }
                break;
            case 5: // MainPage.xaml line 32
                {
                    this.tbMaxNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 35
                {
                    this.styleCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.styleCombobox).SelectionChanged += this.styleCombobox_SelectionChanged;
                }
                break;
            case 8: // MainPage.xaml line 43
                {
                    this.mapTypeCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.mapTypeCombobox).SelectionChanged += this.mapTypeCombobox_SelectionChanged;
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.projectionCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.projectionCombobox).SelectionChanged += this.projectionCombobox_SelectionChanged;
                }
                break;
            case 10: // MainPage.xaml line 26
                {
                    this.prRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

