---
title: "Walkthrough: Printing an Invoice from a LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9a8f146d-b566-4c1f-a0ac-7d0104381008
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Printing an Invoice from a LightSwitch Application
You can’t print directly from a LightSwitch application, but you can create a Silverlight user control that implements printing and add it to a LightSwitch screen. This walkthrough shows how to print an invoice by creating a Silverlight user control and using it as a custom control on a form.  
  
##  <a name="LS"></a> Create the LightSwitch Application  
 First, you create a simple LightSwitch application with Customer and Order entities and a List and Details screen to display them.  
  
#### To create the application  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the **New Project** dialog box, expand the **LightSwitch** node, and then choose either the **LightSwitch Desktop Application (Visual Basic)** or **LightSwitch Desktop Application (Visual C#)** template.  
  
3.  In the **Name** text box, enter `LightSwitchInvoice`, and then choose the **OK** button.  
  
4.  In the **LightSwitchInvoice Designer** window, choose the **Create New Table** link.  
  
5.  In the **Properties** window, set the value of the **Name** property to `Customer`.  
  
6.  In the entity designer, choose the **<Add Property\>** link, and then enter `Name`.  
  
7.  In the **Type** column, choose the `String` data type.  
  
8.  On the toolbar, choose the **New Table** button.  
  
9. In the **Properties** window, set the value of the **Name** property to `Order`.  
  
10. In the entity designer, choose the **<Add Property\>** link, and then enter `OrderItem`.  
  
11. In the **Type** column, choose the `String` data type.  
  
12. In the entity designer, choose the **<Add Property\>** link, and then enter `OrderAmount`.  
  
13. In the **Type** column, choose the `Money` data type.  
  
14. On the toolbar, choose the **Relationship** button.  
  
     The **Add New Relationship** dialog box appears.  
  
15. In the **To** column of the **Name** row, choose **Customer**, and then choose the **OK** button.  
  
16. In **Solution Explorer**, open the shortcut menu for **Customers**, and then choose **Open**.  
  
17. In the entity designer, choose the **<Add Property\>** link, and then enter `OrderTotal`.  
  
18. In the **Type** column, choose the `Money` data type.  
  
19. In the **Properties** window, select the **Is Computed** check box, and then choose the **Edit Method** link.  
  
20. In the code editor, add the following code for the `OrderTotal_Compute` method:  
  
    ```vb  
    result = (From items In Orders).Sum(Function(X) X.OrderAmount)  
    ```  
  
    ```c#  
    result = (from items in Orders select items).Sum(X => X.OrderAmount);  
    ```  
  
21. In **Solution Explorer**, open the shortcut menu for **Screens**, and then choose **Add Screen**.  
  
22. In the **Add New Screen** dialog box, choose the **List and Details Screen** template.  
  
23. In the **Screen Data** list, choose **Customers**.  
  
24. Select the **Customer Orders** check box, and then choose the **OK** button.  
  
25. In the screen designer, on the toolbar choose the **Add Data Item** button.  
  
26. In the **Add Data Item** dialog box, choose **Local Property**, and in the Name text box enter InvoiceDate, and then choose the **OK** button.  
  
27. On the toolbar, open the **Write Code** list and choose **CustomersListDetail_Created**.  
  
28. In the code editor, add the following code for the **CustomersListDetail_Created** method:  
  
    ```vb  
    InvoiceDate = DateTime.Today.ToShortDateString()  
    ```  
  
    ```c#  
    InvoiceDate == DateTime.Today.ToShortDateString();  
    ```  
  
29. On the menu bar, choose **Debug**, **Start Debugging**.  
  
30. On the **Customers** toolbar, choose the **Add** button.  
  
     The **Add New Order** dialog box appears.  
  
31. In the **Name** text box, enter `Derek Snyder`, and then choose the **OK** button.  
  
32. On the **Orders** toolbar, choose the **Add** button.  
  
33. In the **Order Item** text box, enter `Hammer`.  
  
34. In the **Order Amount** text box, enter `9.95`, and then choose the **OK** button.  
  
35. On the **Orders** toolbar, choose the **Add** button.  
  
36. In the **Order Item** text box, enter `Nails`.  
  
37. In the **Order Amount** text box, enter `4.50`, and then choose the **OK** button.  
  
38. On the **Application** toolbar, choose **Save**, and then close the application.  
  
##  <a name="SL"></a> Create the Silverlight User Control  
 Next, you create a Silverlight user control that provides printing capabilities.  
  
#### To create a user control  
  
1.  On the menu bar, choose **File**, **Add**, **New Project**.  
  
2.  In the **New Project** dialog box, expand either the **Visual Basic** or **Visual C#** node, choose the **Silverlight** node, and then choose the **Silverlight Class Library** template.  
  
3.  In the **Name** text box, enter `PrintControl`, and then choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for **Class1.vb** or **Class1.cs**, and then choose **Delete**.  
  
5.  Open the shortcut menu for **PrintControl**, choose **Add**, and then choose **New Item**.  
  
6.  In the **Add New Item** dialog box, choose the **Silverlight User Control** template.  
  
7.  In the **Name** text box, enter `Invoice`, and then choose the **OK** button.  
  
8.  On the menu bar, choose **View**, **Toolbox**.  
  
9. In the **Toolbox** window, expand the **Common Silverlight Controls** node, choose the **DataGrid** control, and add it to the design surface.  
  
10. In the code editor, replace the existing XAML code with the following code:  
  
    ```xaml  
    <UserControl  
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"  
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
        xmlns:sdk="http://schemas.microsoft.com/winfx/2006/xaml/presentation/sdk" x:Class="PrintControl.Invoice"  
        mc:Ignorable="d" d:DesignWidth="474" Height="278">  
        <StackPanel>  
  
            <Button Content="Print" x:Name="btnPrint" Click="PrintButton_Click" />  
  
            <Border BorderThickness="1" BorderBrush="#FF504F4F">  
  
                <Grid x:Name="LayoutRoot" Margin="-1,0,1,0">  
  
                    <Grid.ColumnDefinitions>  
  
                        <ColumnDefinition Width="0.02*"/>  
  
                        <ColumnDefinition Width="0.2*"/>  
  
                        <ColumnDefinition Width="0.5*"/>  
  
                        <ColumnDefinition Width="0.1*"/>  
  
                        <ColumnDefinition Width="0.18*"/>  
  
                    </Grid.ColumnDefinitions>  
  
                    <Grid.RowDefinitions>  
  
                        <RowDefinition Height="0.053*"/>  
  
                        <RowDefinition Height="0.08*"/>  
  
                        <RowDefinition Height="0.533*"/>  
  
                        <RowDefinition Height="0.133*"/>  
  
                        <RowDefinition Height="0.2*"/>  
  
                    </Grid.RowDefinitions>  
  
                    <sdk:DataGrid ItemsSource="{Binding Screen.Orders, Mode=OneWay}"  
  
                AutoGenerateColumns="False" Grid.Row="2" Grid.Column="1" Grid.ColumnSpan="2" >  
  
                        <sdk:DataGrid.Columns>  
  
                            <sdk:DataGridTextColumn Binding="{Binding OrderItem}" CanUserSort="True" DisplayIndex="0"  
  
                Header="Order Item" MaxWidth="100" MinWidth="50" Visibility="Visible" Width="Auto"/>  
  
                            <sdk:DataGridTextColumn Binding="{Binding OrderAmount, StringFormat=C}" CanUserSort="True" DisplayIndex="1"  
  
                Header="Order Amount" MaxWidth="100" MinWidth="50" Visibility="Visible" Width="Auto"/>  
  
                        </sdk:DataGrid.Columns>  
  
                    </sdk:DataGrid><TextBlock TextWrapping="Wrap" Text="Invoice Date:" FontWeight="Bold" VerticalAlignment="Top"  
  
                           Grid.Column="1" HorizontalAlignment="Left" Margin="0,0,5,0"/>  
  
                    <TextBlock x:Name="InvoiceDate" TextWrapping="Wrap" Text="{Binding Screen.InvoiceDate}" Grid.Column="2" HorizontalAlignment="Left" VerticalAlignment="Top" />  
               <TextBlock TextWrapping="Wrap"  
  
                    Text="Invoice For:" FontWeight="Bold" Grid.Row="1" VerticalAlignment="Top" HorizontalAlignment="Left"   
  
                    Grid.Column="1" Margin="0,0,5,0"/>  
  
                    <TextBlock TextWrapping="Wrap"  
  
                    Text="{Binding Screen.Customers.SelectedItem.Name}" Grid.Row="1" Grid.Column="2"   
  
                           HorizontalAlignment="Left" VerticalAlignment="Top"/>  
  
                    <Rectangle Grid.Column="2" Fill="#FF010108" Height="8" Stroke="Black" VerticalAlignment="Bottom" Grid.Row="3"/>  
  
                    <TextBlock TextWrapping="Wrap"  
  
                    Text="Total:" FontWeight="Bold" Grid.Row="4" VerticalAlignment="Top" Grid.Column="1"  
  
                     TextAlignment="Right" Margin="0,0,4,0"/>  
  
                    <TextBlock Grid.Column="2" Height="16" Grid.Row="4" TextWrapping="Wrap"  
  
                Text="{Binding Screen.Customers.SelectedItem.OrderTotal, StringFormat=C}"  
  
                           VerticalAlignment="Top" Margin="4,0,0,0"/>       
                </Grid>  
            </Border>  
        </StackPanel>  
    </UserControl>  
    ```  
  
     This XAML code defines the layout of the control. The `<sdk:DataGrid.Columns>` section specifies what will appear in each column of the `DataGrid` (in this case, the `OrderItem` and `OrderAmount` fields from the `Customers` entity).  
  
11. In **Solution Explorer**, expand the **Invoice.xaml** node, open the shortcut menu for **Invoice.xaml.vb** or **Invoice.xaml.cs**, and then choose **Open**.  
  
12. In the code editor, replace the existing code with the following code:  
  
    ```vb  
    Imports System.Windows.Printing  
  
    Partial Public Class Invoice  
        Inherits UserControl  
        Private WithEvents pd As PrintDocument  
        Public Sub New()  
            InitializeComponent()  
            pd = New PrintDocument  
            Dim InvoiceDate As String  
             InvoiceDate = DateTime.Today.ToShortDateString()  
        End Sub  
        Private Sub PrintButton_Click(ByVal sender As Object, _  
                ByVal e As RoutedEventArgs)  
            pd.Print(String.Format("Invoice Date: {0}", DateTime.Today.ToShortDateString()))  
        End Sub  
        Private Sub pd_PrintPage(ByVal sender As Object, _  
                ByVal e As PrintPageEventArgs) Handles pd.PrintPage  
            e.PageVisual = LayoutRoot  
        End Sub  
  
    End Class  
    ```  
  
    ```c#  
    using System.Windows.Printing;  
  
    public partial class Invoice : UserControl  
    {  
    private PrintDocument withEventsField_pd;  
    private PrintDocument pd {  
    get { return withEventsField_pd; }  
    set {  
    if (withEventsField_pd != null) {  
    withEventsField_pd.PrintPage -= pd_PrintPage;  
    }  
    withEventsField_pd = value;  
    if (withEventsField_pd != null) {  
    withEventsField_pd.PrintPage += pd_PrintPage;  
    }  
    }  
    }  
    public Invoice()  
    {  
    InitializeComponent();  
    pd = new PrintDocument();  
    string InvoiceDate = null;  
                InvoiceDate = DateTime.Today.ToShortDateString();  
    }  
    private void PrintButton_Click(object sender, RoutedEventArgs e)  
    {  
    pd.Print(string.Format("Invoice Date: {0}", DateTime.Today.ToShortDateString()));  
    }  
    private void pd_PrintPage(object sender, PrintPageEventArgs e)  
    {  
    e.PageVisual = LayoutRoot;  
    }  
    }  
  
    ```  
  
13. On the menu bar, choose **Build**, **BuildSolution**.  
  
## Consume the User Control  
 Lastly, you add the user control to the [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] screen and test it.  
  
#### To add the user control  
  
1.  In **Solution Explorer**, open the shortcut menu for the **CustomersListDetail.lsml** screen, and then choose **Open**.  
  
2.  In the screen designer, choose the **Rows Layout &#124; Customer Details** node.  
  
3.  On the toolbar, open the **Add Layout Item** list, and then choose **Custom Control**.  
  
4.  In the **Add Custom Control** dialog box, choose the **Add Reference** button.  
  
5.  In the **Reference Manager** dialog box, expand the **Solution** node, select the **PrintControl** check box, and then choose the **OK** button.  
  
6.  In the **Add Custom Control** dialog box, expand the **PrintControl** nodes, choose the **Invoice** control, and then choose the **OK** button.  
  
7.  In the screen editor, choose the **Custom Control &#124; Screen Content** node, and drag it so it appears below the **Data Grid &#124; Orders** node.  
  
8.  In the **Properties** window, set the value of the **Name** property to `Invoice`.  
  
9. In the **Sizing** group, choose the **Stretch** option buttons for **Horizontal Alignment** and **Vertical Alignment**.  
  
10. On the menu bar, choose **Debug**, **Start Debugging** to run the application.  
  
11. In the running application, choose the **Print** button.  
  
     When the Windows **Print** dialog box appears, you can choose a printer.  
  
## See Also  
 [Reporting and Printing in LightSwitch](../vs140/reporting-and-printing-in-lightswitch.md)