---
title: "How to: Modify an HTML Screen by Using Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9ee853c5-7ce2-4f85-86a3-0bbb6bbbedd9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Modify an HTML Screen by Using Code
When you design HTML screens for a LightSwitch application, you primarily use designers and tool windows, but you can also use code to modify those screens in specific ways. By using LightSwitch JavaScript APIs, you can perform the following data-related tasks.  
  
-   [Set a default value on a data entry screen](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#SetDefault)  
  
-   [Format a number](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Format)  
  
-   [Format a Date](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Date)  
  
-   [Change the background color and font color for list items](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#ChangeColor)  
  
-   [Mark fields as required](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Requiredfield)  
  
-   [Validate data on a screen](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Validate)  
  
-   [Delete an item from a screen or a popup](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Delete)  
  
-   [Create a custom modal picker by using a popup](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Popup)  
  
-   [Center a popup on a screen](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#CenterPopup)  
  
-   [Show a message box, and respond to a user selection](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Message)  
  
-   [Set the screen title dynamically](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Title)  
  
-   [Change the title of an application](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#ChangeTitle)  
  
-   [Enable or disable a button](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Button)  
  
-   [Customize the Save command to save to multiple data sources](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Save)  
  
-   [Return focus to a selected item in a list](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#ReturnFocus)  
  
-   [Use a JQuery Mobile control](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#JQuery)  
  
-   [Customize a FlipSwitch control](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#FlipSwitch)  
  
-   [Implement a CheckBox control](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#ImplementCheckbox)  
  
-   [Override the appearance of a custom control](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#OverrideAppearance)  
  
-   [Get the location of a device](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Location)  
  
-   [Display a location on a map](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Map)  
  
-   [Show a numeric keyboard on a device](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Keyboard)  
  
-   [Adjust the UI for different form factors](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#FormFactor)  
  
-   [Render HTML data directly on a screen](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#Render)  
  
-   [Display a title on a popup](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#PopupTitle)  
  
-   [Copy information to a new screen](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#CopyInfo)  
  
-   [Change screen navigation when saving](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#ChangeNav)  
  
-   [Disable bookmarking](../VS_csharp/how-to--modify-an-html-screen-by-using-code.md#disable)  
  
##  <a name="SetDefault"></a> Set a default value on a data entry screen  
 When you create a data entry screen, you may want to populate some fields with default values. For example, you might set the default value of a date field to the current date. To set default values in any **Add/Edit Details** screen that targets an entity, you write code in the `created` method of that entity.  
  
#### To set default values  
  
1.  In the Entity Designer, on the **Perspective** bar, choose the **HTMLClient** tab.  
  
2.  In the **Write Code** list, choose **created**.  
  
3.  In the Code Editor, set the initial values by adding code to the `created` method:  
  
    ```javascript  
    entity.OrderDate = new Date();  
    entity.OrderStatus = 'New';  
    ```  
  
     Any **Add/Edit Details** screen that you create for the entity will automatically display these default values.  
  
##  <a name="Format"></a> Format a number  
 Because some mobile devices have limited screen space, you may want to format numbers to show less precision. The following example shows how to format a number that's stored as a `Double` to show only two decimal places.  
  
#### To format a number  
  
1.  In the **Screen Designer**, choose the node for the number that you want to format.  
  
2.  On the toolbar, open the **Write Code** list, and then choose the `postRender` method.  
  
3.  In the Code Editor, add the following code to the `postRender` method:  
  
    ```javascript  
    contentItem.dataBind("value", function (value) {  
            if (value) {  
                $(element).text(value.toFixed(2));  
            }  
        });  
    ```  
  
##  <a name="Date"></a> Format a Date  
 To changing the display format of a date, you must use a JavaScript library such as [Moment.js](http://momentjs.com/). After you add the library to your project, you  add a reference in the default.htm file and then write code in the **Render** or **postRender** method.  
  
#### To add the library  
  
1.  In **Solution Explorer**, open the shortcut menu for the **HTMLClient** node, and then choose **Manage NuGet Packages**.  
  
2.  In the **Manage NuGet Packages** dialog box, choose the **Online** node.  
  
3.  In the **Search Online** text box, enter **moment.js**.  
  
4.  Choose the **Install** button to install the Moment.js library, and then choose the **Close** button.  
  
#### To add a reference  
  
1.  In **Solution Explorer**, expand the **HTMLClient** node, and then open the **default.htm** file.  
  
2.  In the code editor, add the following script tag after the last `</script>` tag:  
  
    ```html  
    <script type="text/javascript" src="Scripts/moment.js" charset="utf-8"></script>  
    ```  
  
#### To format dates  
  
1.  In **Solution Explorer**, open the screen where you want to format a date.  
  
2.  In the Screen Designer, choose the node where you want to apply the date format.  
  
3.  On the toolbar, open the **Write Code** list, and then choose the `postRender` method.  
  
4.  In the Code Editor, add the following code to the `postRender` method:  
  
    ```javascript  
    contentItem.dataBind("value", function (value) {  
            if (value) {  
                $(element).text(moment(value).format("DD/MM/YYYY"));  
            }  
        });  
    ```  
  
##  <a name="ChangeColor"></a> Change the background color and font color for list items  
 The appearance of a **ListView** control is determined by a cascading style sheet (CSS), and the style is quite complex. Rather than trying to edit the CSS, you can use the `postRender` method to change the colors in code. Note that you can’t change the style of the **ListView** itself, but you can change the style of each **List Item** through its parent, the **RowTemplate**. Each **List Item** has a `background-image` defined, so you’ll need to specify a  `background-image` before applying a new **background-color**.  
  
#### To change the colors  
  
1.  In the screen designer, choose the **Rows Layout** (or **Columns Layout**) node for a list.  
  
2.  In the **Properties** window, choose the **Edit PostRender Code** link.  
  
3.  In the Code Editor, add the following code to the `postRender` method:  
  
    ```javascript  
    $(element).parent().css({  
                "background-color": "green",  
                "background-image": "none",  
                color: "yellow"  
            });  
    ```  
  
##  <a name="Requiredfield"></a> Mark fields as required  
 A common convention for showing required fields on a screen is to provide a visual clue, such as using a different font color and displaying an asterisk next to the field name.  
  
#### To highlight a required field  
  
1.  In the screen designer, choose the field to be marked as required.  
  
2.  In the **Properties** window, choose the **Edit PostRender Code** link.  
  
3.  In the Code Editor, add the following code to the `postRender` method:  
  
    ```javascript  
    $(element).parent().css('color', 'red'); $(element).parent().find("label")[0].innerHTML += " *"  
    ```  
  
##  <a name="Validate"></a> Validate data on a screen  
 By providing custom validation logic, you can ensure that only valid data is saved to a data source. You can add validation code in the `beforeApplyChanges` method, which is called when the user taps the **Save** button on an **Add/Edit** screen. In the following example, a message will notify a user who enters an exclamation mark in the **ContactName** field that the character isn't allowed in that field.  
  
#### To validate data  
  
1.  In the **Screen Designer**, in the **Write Code** list, choose **beforeApplyChanges**.  
  
2.  In the Code Editor, add the following code, replacing `Contact` with the name of your entity and `ContactName` with the name of the string field that you want to validate:  
  
    ```javascript  
    if (screen.Contact.ContactName.indexOf('!') != -1) {  
  
            screen.findContentItem("ContactName").validationResults = [  
  
            new msls.ValidationResult(  
  
            screen.Contact.details.properties.contactName,  
  
            "Contact Name cannot contain the character '!'.")  
  
            ];  
  
            return false;  
  
        }  
    ```  
  
##  <a name="Delete"></a> Delete an item from a screen or a popup  
 LightSwitch provides built-in methods for adding and editing items on an HTML screen but not for deleting them. You can easily create your own method for deleting items from either a screen or  a popup.  
  
#### To delete an item  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
2.  In the **Add Data Item** dialog box, choose the **Method** option button, and then enter a name for the method.  
  
3.  Open the shortcut menu for the method, and then choose **Edit Execute Code**.  
  
4.  In the Code Editor, add the following code, replacing `myScreen` with the name of your screen and both instances of `customers` with the name of your entity:  
  
    ```javascript  
    myapp.MyScreen.DeleteSelected_execute = function (screen) {  
        screen.getCustomers().then(function (customers) {  
            customers.deleteSelected();  
        });  
    };  
    ```  
  
     The method will be available in the **Add Button** dialog box for any screen or popup that displays the entity.  
  
##  <a name="Popup"></a> Create a custom modal picker by using a popup  
 You can allow users to pick an item from a list if you display a modal dialog, which you can easily accomplish by adding a screen query and a popup. In this example, you have an **Add/Edit Details** screen that's named **AddOrders**, which is based on an **OrderDetails** entity, and a second related entity that's named **Products**.  
  
#### To create a modal picker  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
2.  In the **Add Data Item** dialog box, choose the **Query** option button, and then choose **Products** from the list.  
  
     The **Products** query appears in the left pane of the **Screen Designer**.  
  
3.  In the content tree, open the shortcut menu for the **Popup** node, and then choose **Add Popup**.  
  
4.  In the **Add** list, choose **Products**.  
  
5.  On the toolbar, in the **Write Code** list, choose **created**.  
  
6.  In the Code Editor, add the following code to the created method:  
  
    ```javascript  
    myapp.AddOrders.created = function (screen) {  
            screen.findContentItem("Products").dataBind("value.selectedItem", function (newValue) {  
                if (newValue !== undefined && newValue !== null) {  
                    //Whenever selectedItem for Products changes, update the Product value on the main page   
                    screen.Order_Detail.setProduct(screen.Products.selectedItem);  
  
                    //Close popup, if one is open.   
                    screen.closePopup();  
                }  
            });  
        };  
    ```  
  
7.  In the **Screen Designer**, open the shortcut menu for the **Command Bar** node, and then choose **Add Button**.  
  
8.  In the **Add Button** dialog box, choose the **OK** button.  
  
9. (Optional) To clear the field, add a screen method with the following code:  
  
    ```javascript  
    myapp.AddOrders.Clear_execute = function (screen) {  
        //Clear the selection for Product. (Useful for 0...1 to many relationships.)   
        screen.Order_Detail.setProduct(undefined);  
    };  
    ```  
  
##  <a name="CenterPopup"></a> Center a popup on a screen  
 The default location for a popup is at the bottom of a screen; bottom right for wider screens. On large screens the location might make it difficult to notice the popup. The following example positions the popup in the center of the screen, making it more noticeable.  
  
#### To center a popup  
  
1.  In the screen designer, choose the button node that launches the popup.  
  
2.  In the **Properties** window, under **Actions**, choose the **Tap** link.  
  
3.  In the **Edit Tap Action** dialog box, choose the **Write my own method** option button, give it a name, and then choose the **OK** button.  
  
4.  In the **Properties** window, choose the **Edit Execute Code** link.  
  
5.  In the Code Editor, add the following code to the `execute` method:  
  
    ```javascript  
    // Note:If using JQuery Mobile 1.3 (or higher) use  
        // "popupcreate" rather than "popupbeforeposition"  
        $(window).one("popupbeforeposition", function (e) {  
            $(e.target).popup({  
                positionTo: "window"  
            });  
        });  
  
        // Show the Popup  
        screen.showPopup("Popup1");  
  
    ```  
  
##  <a name="Message"></a> Show a message box, and respond to a user selection  
 By showing a message box, you can offer users a choice and then perform an action based on their selections. The following example displays a different message in response to each choice in a Yes/No/Cancel message box. In your own code, you can replace the alert code with code to perform your own action, for example, displaying different screens based on the user’s choice.  
  
#### To show a message box  
  
1.  In the **Screen Designer**, open the shortcut menu for the **Command Bar** node, and then choose **Add Button**.  
  
2.  In the **Add Button** dialog box, choose the **Write my own method** option button, and then name the method `ShowMessageBox`.  
  
3.  In the Code Editor, add the following code to the `ShowMessageBox_execute` method:  
  
    ```javascript  
    msls.showMessageBox("Please choose the appropriate button", {  
  
            title: "This is a message box",  
  
            buttons: msls.MessageBoxButtons.yesNoCancel  
  
        }).then(function (result) {  
  
            if (result === msls.MessageBoxResult.yes) {  
  
                alert("Yes button was chosen");  
  
            }  
  
            else if (result === msls.MessageBoxResult.no) {  
  
                alert("No button was chosen");  
  
            }  
  
            else if (result === msls.MessageBoxResult.cancel) {  
  
                alert("Please choose either Yes or No");  
  
            }  
  
        });  
    ```  
  
##  <a name="Title"></a> Set the screen title dynamically  
 You may want to change the screen title based on information that isn’t available at design time, such as the name of the currently selected customer. The following code example dynamically displays the screen title for a screen that's named **ViewCustomer**, which is based on an entity that's named **Customer**.  
  
#### To set the screen title  
  
1.  In the **Screen Designer**, in the **Write Code** list, choose **created**.  
  
2.  In the Code Editor, add the following code to the created method:  
  
    ```javascript  
    myapp.ViewCustomer.created = function (screen) {  
  
    var name;  
  
        name = screen.Customer.CompanyName;  
        screen.details.displayName = "Information about: " + name;  
    };  
    ```  
  
##  <a name="ChangeTitle"></a> Change the title of an application  
 By default, the name of your project appears as the title of your application in the splash screen and the title bar or browser tab. You can specify a different title by modifying the default.htm file for your project.  
  
#### To change the title  
  
1.  In **Solution Explorer**, under the **HTMLClient** node, open the shortcut menu for the **default.htm** file, and then choose **Open**.  
  
2.  In the Code Editor, locate the `<title>` element, and replace the existing value with your title.  
  
     This string will appear in the title bar or browser tab.  
  
3.  Locate the `<div>` element, and replace the existing value with your title.  
  
     This string will appear in the splash screen.  
  
##  <a name="Button"></a> Enable or disable a button  
 You'll often need to enable or disable a button based on certain criteria. For example, you might disable a screen launch button for certain users, or you might enable an add button only if a value is needed. The first example shows how to disable a button by setting the `IsEnabled` property from code.  
  
 The second example shows a two-pass approach that's based on the `CanExecute` method. Data is loaded asynchronously in LightSwitch, but the `CanExecute` methods for buttons are synchronous. Therefore, you can't enable a button based on loaded data in a single pass, but you can implement a two-pass method by using the `IsLoaded` property.  
  
#### To disable a button by using the IsEnabled property  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
2.  In the **Add Data Item** dialog box, choose the **Method** option button, and then enter a name for the method.  
  
3.  Open the shortcut menu for the method, and then choose **Edit Execute Code**.  
  
4.  In the Code Editor, add the following code, replacing `MyButton` with the name of your button:  
  
    ```javascript  
    screen.findContentItem("MyButton").isEnabled = false;  
    ```  
  
     The method can be called from code whenever you need to disable or enable the button.  
  
    > [!TIP]
    >  To hide or show a button, use the `IsVisible` property.  
  
#### To enable a button by using the IsLoaded property  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
2.  In the **Add Data Item** dialog box, choose the **Method** option button, and then enter a name for the method.  
  
3.  Open the shortcut menu for the method, and then choose **Edit CanExecute Code**.  
  
4.  In the Code Editor, add the following code, replacing `Orders` with the name of your entity, `Photo` with the name of your entity property, and `GetPhoto` with the name of the function that you want to execute:  
  
    ```javascript  
    var result = false;   
    if (!screen.Order.details.properties.Photo.isLoaded) {   
    screen.Order.getPhoto();   
    } else {   
    screen.Order.getPhoto().then(function (ph) {   
    result = !ph;   
    });   
    }   
    return result;  
  
    ```  
  
     The `CanExecute` method is called when the screen is created. In the first pass, the code verifies whether the `Photo` property is already loaded. If it isn't, the code loads the data, and the function ends. After the data is loaded, the `CanExecute` method is called again, and the `else` branch runs. This time, the `GetPhoto` function runs synchronously because the data is already loaded, which guarantees a valid result.  
  
##  <a name="Save"></a> Customize the Save command to save to multiple data sources  
 You can save updates from one screen to multiple data sources by using the WinJs `Promise` objectto customize the built-in **Save** command.  
  
#### To save to multiple data sources  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Write Code** button.  
  
2.  In the Code Editor, add the following code to the `onsavechanges` method, replacing `NorthwindData` and `ApplicationData` with the names of your data sources:  
  
    ```javascript  
    myapp.onsavechanges = function (e) {  
  
        var promises = [];  
  
        promises.push(myapp.activeDataWorkspace.NorthwindData.saveChanges());  
  
        promises.push(myapp.activeDataWorkspace.ApplicationData.saveChanges());  
  
        e.detail.promise = WinJS.Promise.join(promises);  
  
    };  
  
    ```  
  
     If you need more data sources, you can add a `promises.push…` line for each source.  
  
##  <a name="ReturnFocus"></a> Return focus to a selected item in a list  
 After navigating from a list item to a **View** or **Edit** screen, the default behavior is to return focus to the first item in the list. It is often desirable to return focus to the list item that launched the screen, especially in large lists that require scrolling. You can modify the behavior to return to the previously selected list item by binding to a `Custom Method` and using the JQuery `scrollTop` method.  
  
#### To set the focus  
  
1.  In the screen designer, choose the **List** node where you want to implement the behavior.  
  
2.  In the **Properties** window, under **Actions**, choose the **Tap** link.  
  
3.  In the **Edit Tap Action** dialog box, choose the **Write my own method** option button, and then choose the **OK** button.  
  
4.  In the **Properties** window, choose the **Edit Execute Code** link.  
  
5.  In the Code Editor, add the following code to the `Tap_execute` method:  
  
    ```javascript  
    var scrollTopPosition = $(window).scrollTop();  
        myapp.showViewOrder(screen.Orders.selectedItem, {  
            afterClosed: function () {  
                $(window).scrollTop(scrollTopPosition);  
            }  
        });  
    ```  
  
##  <a name="JQuery"></a> Use a JQuery Mobile control  
 The Screen Designer provides a limited set of controls for displaying data, but you can easily add JQuery Mobile controls for a richer UI experience. The JQuery Mobile Foundation library contains a wide variety of controls that are optimized for mobile devices, including sliders, radio buttons, check boxes, and many more. See [JQuery Mobile Framework](http://go.microsoft.com/fwlink/?LinkId=293643).  
  
 The following example adds a slider control for setting a numeric value in a text box control.  
  
#### To add a slider control  
  
1.  In the **Screen Designer**, choose the node for a numeric field.  
  
2.  Replace the **Text Box** control with a **Custom Control**.  
  
3.  In the **Properties** window, set the **Width** property to **Stretch to Container**.  
  
4.  Choose the **Edit Render Code** link, and in the **Code Editor**, add the following code to the `render` method:  
  
    ```javascript  
    createSlider(element, contentItem, 0, 100);  
    ```  
  
    > [!NOTE]
    >  The default values for the slider range from 0 to 100. If necessary, replace them with values that are appropriate to your application.  
  
5.  Add the following function to the screen’s code file:  
  
    ```javascript  
    function createSlider(element, contentItem, min, max) {  
        // Generate the input element.var value = contentItem.value || 0,  
            $element = $(element)  
                .append('<input type="range" min="' + min + '" max="' + max + '" value="' + value + '"/>')  
                .on("slidestop", function () {  
                    contentItem.value = $element.find("input").val();  
                });  
  
    ```  
  
##  <a name="FlipSwitch"></a> Customize a FlipSwitch control  
 The **FlipSwitch** control that displays `Boolean` values provides only two options for the display text: **Yes**/**No** or **On**/**Off**. If you want to display different values, you can create a custom control that's based on the **FlipSwitch** control. The following example creates a True/False control.  
  
#### To customize the control  
  
1.  In the **Screen Designer**, choose the node for a `Boolean` field.  
  
2.  Change the control type from **FlipSwitch** to **Custom Control**.  
  
3.  In the **Properties** window, choose the **Edit Render Code** link.  
  
4.  In the code editor, add the following code to the render method:  
  
    ```javascript  
    createBooleanSwitch(element, contentItem);  
    ```  
  
5.  Add the following function to the screen’s code file:  
  
    ```javascript  
    function createBooleanSwitch(element, contentItem) {  
        var $flipSwitch = $('<select data-role="slider"></select>').appendTo($(element));  
        $('<option value="false">false</option>').appendTo($flipSwitch);  
        $('<option value="true">true</option>').appendTo($flipSwitch);  
  
        // set select value to match the original contentItem.value  
        $flipSwitch.val((contentItem.value) ? "true" : "false");  
  
        // add listener to update contentItem's value if slider changes  
        $flipSwitch.change(function () {  
            contentItem.value = ($flipSwitch.val() == "true");  
        });  
  
        // visually refresh the slider.  
        $flipSwitch.slider().slider("refresh");  
    };  
    ```  
  
    > [!NOTE]
    >  You may need to set the **Width** property to a value of 150 or greater to get the control to appear properly.  
  
##  <a name="ImplementCheckbox"></a> Implement a CheckBox control  
 The default control type for a `Boolean` data type is the **FlipSwitch** control, but you can easily substitute a **CheckBox** by using a custom control.  
  
#### To display a CheckBox  
  
1.  In the screen designer, choose the node for a `Boolean` field, and change the control type from **FlipSwitch** to **Custom Control**.  
  
2.  In the **Properties** window, in the **Height** section, choose **Min** and enter `100`.This is necessary because the **CheckBox** control is taller than a standard **TextBox** control. If your form uses other control types, you may need to adjust this value.  
  
3.  In the **General** section, choose the **Edit Render Code** link.  
  
4.  In the Code Editor, add the following code to the `render` method:  
  
    ```javascript  
    // Create the checkbox and add it to the DOM.  
        var checkbox = $("<input type='checkbox'/>")  
                .css({  
                    height: 20,  
                    width: 20,  
                    margin: "10px"  
                })  
                .appendTo($(element));  
  
        // Determine if the change was initiated by the user.  
        var changingValue = false;  
  
        checkbox.change(function () {  
            changingValue = true;  
            contentItem.value = checkbox[0].checked;  
            changingValue = false;  
        });  
        contentItem.dataBind("value", function (newValue) {  
            if (!changingValue) {  
                checkbox[0].checked = newValue;  
            }  
        });  
    ```  
  
 If you’re displaying a **CheckBox** for a required field on an **Add/Edit** screen, you’ll also want to set an initial value for the control, otherwise the user may get a validation error.  
  
#### To set an initial value  
  
1.  In the Entity Designer, on the **Perspective** bar, choose the **HTMLClient** tab.  
  
2.  In the **Write Code** list, choose **created**.  
  
3.  In the Code Editor, set the initial values by adding code to the `created` method:  
  
    ```javascript  
    entity.FieldName = new Boolean();  
        entity.FieldName = 'true';  
    ```  
  
     Replace `FieldName` with the name of your `Boolean` field. To initialize the control to an unchecked state, replace `true` with `false`.  
  
##  <a name="OverrideAppearance"></a> Override the appearance of a custom control  
 Custom controls are based on the JQuery Mobile framework, and the framework automatically styles certain controls so that they’re optimized for display on mobile devices. In some cases you might want to override the appearance to provide a more traditional style, For example, JQuery Mobile buttons are larger than a traditional button control. You can use the `data-role="none"` attribute to override the style and display a normal button.  
  
#### To apply the attribute  
  
1.  In the screen designer, choose the custom control node.  
  
2.  In the **Properties** window, choose the **Edit Render Code** link.  
  
3.  Add the following code to the `render` method:  
  
    ```javascript  
    var $element = $(element);  
        var $textbox1 = $('<input type="text" data-role="none"/>');  
        $element.append($textbox1);  
    ```  
  
    > [!NOTE]
    >  Replace `textbox1` with the name of your custom control, and replace `“text”` with the control type.  
  
##  <a name="Location"></a> Get the location of a device  
 You can enable mapping and proximity-based scenarios by using the geolocation APIs to determine the current location of a particular device. The following example determines the coordinates for an entity that's named `MyLocation` with properties of type `Double` that are named `Latitude` and `Longitude`.  
  
#### To get the location  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Write Code** button.  
  
2.  In the Code Editor, add the following method:  
  
    ```javascript  
    myapp.AddEditMyLocation.GetGeolocation_execute = function (screen) {  
  
    if (navigator.geolocation) {   
    navigator.geolocation.getCurrentPosition(function (pos) {   
    screen.MyLocation.latitude = pos.coords.latitude.toString();   
    screen.MyLocation.longitude = pos.coords.longitude.toString();   
    });   
    }   
    else {   
    alert("Geolocation not supported");   
    }   
    };  
  
    ```  
  
##  <a name="Map"></a> Display a location on a map  
 To easily add mapping functionality, you get a free developer key from the [Bing Maps SDK](http://go.microsoft.com/fwlink/?LinkId=209480) and then create a custom control that calls the Bing Maps web service.  
  
 The following example shows customer locations as pushpins on a map, and you can display details about each customer by tapping a pushpin. This example requires a screen that's named **BrowseCustomers** to be attached to a **Customers** entity that has **Address**, **City**, and **Country** fields, and a popup that's named **Details** must be on the **BrowseCustomers** screen.  
  
#### To create the custom control  
  
1.  In **Solution Explorer**, choose the **Scripts** node, and then add a JavaScript file that's named `lightswitch.bing-maps.js`.  
  
2.  In the Code Editor, add the following code to that file:  
  
    ```javascript  
    /// <reference path="jquery-1.7.1.js" />  
    /// <reference path="jquery.mobile-1.1.1.js" />  
    /// <reference path="msls-1.0.0.js" />  
  
    (function ($) {  
        var _credentialsKey = "Ao75sYhQSfLgssT0QkO9n22xt0lgxzntrZ1xpCwLOC-kGhI584OYED3viFXLIWgC";  
  
        // load the directions module only once per session  
        Microsoft.Maps.loadModule('Microsoft.Maps.Directions');  
  
        $.widget("msls.lightswitchBingMapsControl", {  
            options: {  
                mapType: Microsoft.Maps.MapTypeId.road,  
                zoom: 3,  
                showDashboard: false  
            },  
  
            _create: function () {  
            },  
  
            _init: function () {  
                this.createMap();  
            },  
  
            destroy: function () {  
                this._destroyBingMapsControl();  
            },  
  
            createMap: function () {  
                this.htmlMapElement = this.element[0];  
  
                // create empty map  
                this.map = new Microsoft.Maps.Map(this.htmlMapElement,  
                                    {  
                                        credentials: _credentialsKey,  
                                        mapTypeId: this.options.mapType,  
                                        zoom: this.options.zoom,  
                                        showDashboard: this.options.showDashboard  
                                    });  
            },  
  
            addPinAsync: function (street, city, country, i, callback) {  
  
                var widgetInstance = this;  
  
                // construct a request to the REST geocode service using the widget's  
                // optional parameters  
                var geocodeRequest = "http://dev.virtualearth.net/REST/v1/Locations/" +  
                                     street + "," + city + "," + country +  
                                     "?key=" + _credentialsKey;  
  
                // make the ajax request to the Bing Maps geocode REST service  
                $.ajax({  
                    url: geocodeRequest,  
                    dataType: 'jsonp',  
                    async: true,  
                    jsonp: 'jsonp',  
                    error: function (XMLHttpRequest, textStatus, errorThrown) {  
                        alert(textStatus + " " + errorThrown);  
                    },  
                    success: function (result) {  
                        var coordinates = null;  
  
                        if (result && result.resourceSets && (result.resourceSets.length > 0) &&  
                            result.resourceSets[0].resources && (result.resourceSets[0].resources.length > 0)) {  
  
                            // create a location based on the geocoded coordinates  
                            coordinates = result.resourceSets[0].resources[0].point.coordinates;  
  
                            widgetInstance._createPinFromCoordinates(coordinates, i, callback);  
                        }  
                    }  
                });  
            },  
  
            _createPinFromCoordinates: function(coordinates, i, callback) {  
                var location = new Microsoft.Maps.Location(coordinates[0], coordinates[1]);  
                var pin = new Microsoft.Maps.Pushpin(location, { text: '' + i + '' });  
                Microsoft.Maps.Events.addHandler(pin, 'click', callback);  
                this.map.entities.push(pin);  
            },  
  
            resetMap: function () {  
                this.map.entities.clear();  
            },  
  
            _handleError: function (error) {  
                alert("An error occurred.  " + error.message);  
            },  
  
            _destroyBingMapsControl: function () {  
                if (this.map != null) {  
                    this.map.dispose();  
                    this.map = null;  
                }  
            }  
        });  
    }(jQuery));  
    ```  
  
    > [!IMPORTANT]
    >  Replace the value for `var _credentialsKey` with your own developer key for Bing Maps.  
  
#### To add a map to a screen  
  
1.  In the **Screen Designer**, choose the node where you want to add a map, and then on the shortcut menu choose **Add Custom Control**.  
  
2.  In the **Properties** window, change the **Name** of the control to `Map`, and then choose the **Edit Render Code** link.  
  
3.  In the Code Editor, add the following code to the `render` method:  
  
    ```javascript  
    /// <reference path="../GeneratedArtifacts/viewModel.js" />  
  
    var mapDiv;  
    var current = 0;  
    var step = 15;  
  
    myapp.BrowseCustomers.Customer_render = function (element, contentItem) {  
        mapDiv = $('<div />').appendTo($(element));  
        $(mapDiv).lightswitchBingMapsControl();  
  
        var visualCollection = contentItem.value;  
        if (visualCollection.isLoaded) {  
            showItems(current, step, contentItem.screen);  
        } else {  
            visualCollection.addChangeListener("isLoaded", function () {  
                showItems(current, step, contentItem.screen);  
            });  
            visualCollection.load();  
        }  
    };  
  
    function showItems(start, end, screen) {  
        $(mapDiv).lightswitchBingMapsControl("resetMap");  
  
        $.each(screen.Customers.data, function (i, customer) {  
            if (i >= start && i <= end) {  
                $(mapDiv).lightswitchBingMapsControl("addPinAsync", customer.Address,  
                    customer.City, customer.Country, i + 1, function () {  
                        screen.Customers.selectedItem = customer;  
                        screen.showPopup("Details");  
                    });  
            }  
        });  
    };  
    ```  
  
4.  In **Solution Explorer**, switch to **File View**.  
  
5.  Under the **HTMLClient** node, open the **default.htm** file.  
  
6.  In the Code Editor, add the following reference at the start of the script references block:  
  
    ```html  
    <script type="text/javascript" charset="utf­8" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0"></script>  
    ```  
  
7.  At the end of the script references block, add a reference to the JavaScript file:  
  
    ```html  
    <script type="text/javascript" charset="utf­8" src="Scripts/lightswitch.bing-maps.js"></script>  
    ```  
  
##  <a name="Keyboard"></a> Show a Numeric Keyboard on a Device  
 You can allow users to enter numeric or other types of information by using a custom onscreen keyboard. The following example shows how to display a numeric keypad when a user activates a **Text Box** control.  
  
#### To show a numeric keypad  
  
1.  In the **Screen Designer**, choose a **Text Box** node for a field that should contain numeric data.  
  
2.  In the **Properties** window, choose the **Edit PostRender Code** link.  
  
3.  In the Code Editor, add the following code to the `PostRender` method:  
  
    ```javascript  
    $(element).find("input").get(0).type = "number";  
    ```  
  
    > [!NOTE]
    >  You can use the same technique to show a keyboard for a different type of input, but you can't show a keyboard for the `color` input type in an HTML client of a LightSwitch application.  
  
##  <a name="FormFactor"></a> Adjust the UI for different form factors  
 You can ensure that your application works well on a variety of mobile devices if you customize the interface based on the size of the screen. For example, you might show a customer’s full address on a tablet but hide the same information on a phone to reduce scrolling.  
  
#### To hide a UI element on some devices  
  
1.  In the **Screen Designer**, choose the node that you want to hide, expand the **Write Code** list, and then choose the **postRender** method.  
  
2.  In the Code Editor, add the following code:  
  
    ```javascript  
    $(element).addClass("hidden-on-phone");  
    ```  
  
3.  In **Solution Explorer**, switch to **File View**, and then expand the **Content** node of the **HTMLClient** project.  
  
4.  Open the **user-customizations.css** file.  
  
5.  In the Code Editor, add the following code to the end of the `@media` section:  
  
    ```css  
    .hidden-on-phone {  
           display: none;  
       }  
    ```  
  
     This code adds to the existing media query that determines the screen orientation. When your application appears on a phone, the field won't show.  
  
 You can also show different home screens on phones and tablets by adding JavaScript code to the default.htm file.  
  
#### To show different home screens on different devices  
  
1.  In **Solution Explorer**, choose the **HTMLClient** node, and then open the **default.htm** file.  
  
2.  In the Code Editor, replace the script element that contains the msls.run() function with the following code:  
  
    ```html  
    <script type="text/javascript">  
           $(document).ready(function () {  
               if ($.mobile.media("screen and (max-width: 400px) and (orientation: portrait), \  
                   screen and (max-width: 640px)  and (max-height: 400px) and (orientation: landscape)")) {  
                   var screen = "BrowseCustomersSmall";  
               } else {  
                   var screen = "BrowseCustomers";  
               }  
               msls._run(screen)  
               .then(null, function failure(error) {  
                   alert(error);  
               });  
           });  
       </script>  
    ```  
  
     Replace `BrowseCustomersSmall` with the name of the screen for phones, and replace `BrowseCustomers` with the name of the screen for tablets.  
  
##  <a name="Render"></a> Render HTML data directly on a screen  
 Some databases store HTML in `String` data fields. Your LightSwitch application will interpret that information as regular strings and display the raw HTML in a **Text** control on a screen, tags and all. You can render the actual HTML on the screen by using a custom control and the `render` method.  
  
> [!WARNING]
>  To avoid a security risk, take this approach only if you’re sure that the HTML comes from a trusted source.  
  
#### To render HTML on a screen  
  
1.  In the **Screen Designer**, choose the node that represents the HTML field, and then change the control type to **Custom Control**.  
  
2.  In the **Properties** window, choose the **Edit Render Code** link.  
  
3.  In the Code Editor, add the following code to the `render` method:  
  
    ```javascript  
    element.innerHTML = contentItem.stringValue;  
    ```  
  
##  <a name="PopupTitle"></a> Display a title on a popup  
 Popups provide a quick and easy way to view or enter information without navigating to another screen. Unlike screens, they don’t display a title, but you might want to display a title or other static text on a popup. The following example shows how to display a title and customize its font.  
  
#### To add a title  
  
1.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
2.  In the **Add Data Item** dialog box, add a **Local Property** of type `String`.  
  
3.  In the **Screen Designer**, add the local property to the **Popup**, and then change the control type to **Text**.  
  
4.  In the **Properties** window, set the **LabelPosition** property to None.  
  
5.  In the **Screen Designer**, open the **Write Code** list, and then choose the **postRender** method.  
  
6.  In the Code Editor, add the following code to the `postRender` method:  
  
    ```javascript  
    element.textContent = "This is the title";  
        $(element).css("font-size", "23px");  
        $(element).css("font-weight", "bold");  
    ```  
  
##  <a name="CopyInfo"></a> Copy information to a new screen  
 In data entry applications there is often a need to duplicate some of the information from one entry screen to the next. You can easily implement a copy function using the `beforeShown` method for a form. In the following example, a **Copy** button is added to a **AddEditCustomers** screen, opening a new screen that is pre-populated with the **Country** and **Region** for the current customer.  
  
#### To copy information  
  
1.  In the **Screen Designer**, choose the **Command Bar** node for the **AddEdit** screen where you want to add a **Copy** button  
  
2.  On the toolbar, choose the **Add Layout Item** button, and then choose **Button**.  
  
3.  In the **Add Button** dialog box, choose the **Write my own method** option button and name the method `Copy`, and then choose the **OK** button.  
  
4.  In the left pane, choose the **Copy** node, and then on the toolbar, open the **Write Code** list and choose **Copy_execute**.  
  
5.  In the Code Editor, add the following code to the **Copy_execute** method:  
  
    ```javascript  
    myapp.showAddEditCustomer(null, {  
            beforeShown: function (addNewScreen) {  
                var copied_item = screen.Customer;  
                var new_item = new myapp.Customer;  
                new_item.Country = copied_item.Country;  
                new_item.Region = copied_item.Region;  
                addNewScreen.Customer = new_item;  
            }  
        })  
    ```  
  
##  <a name="ChangeNav"></a> Change screen navigation when saving  
 The default behavior of the **Save** button on an **Add/Edit** screen is to close the screen and return to the screen that launched it. In some cases you might want to navigate to a different screen, for example, a **View** screen that displays the newly added data in a different format. You can do this by writing code in the `afterClosed` method of the button that launches the **Add/Edit** screen. In the following example, an **Add and View Order** button is added to a screen, modifying the behavior so that a **View** screen is shown after saving.  
  
#### To navigate to a new screen  
  
1.  In the **Screen Designer**, choose the **Command Bar** node for the **Browse** screen where you want to add a button  
  
2.  On the toolbar, choose the **Add Layout Item** button, and then choose **Button**.  
  
3.  In the **Add Button** dialog box, choose the **Write my own method** option button and name the method `AddAndViewOrder`, and then choose the **OK** button.  
  
4.  In the left pane, choose the **AddAndViewOrder** node, and then on the toolbar, open the **Write Code** list and choose **AddAndViewOrder _execute**.  
  
5.  In the Code Editor, add the following code to the **AddAndViewOrder_execute** method:  
  
    ```javascript  
    myapp.showAddEditOrder(null, {  
            beforeShown: function (AddEditScreen) {  
                // Create a new order here.  
                var newOrder = new myapp.Order();  
                AddEditScreen.Order = newOrder;  
            },  
            afterClosed: function (addEditScreen, navigationAction) {  
                // If the user commits the change, show the View screen  
                if (navigationAction === msls.NavigateBackAction.commit) {  
                    var newOrder = addEditScreen.Order;  
                    myapp.showViewOrder(newOrder);  
                }  
            }  
        })  
  
    ```  
  
     Note that the code also handles the creation of a new order in the `beforeShown` function. This overrides the default `AddEdit` form behavior and handles the case where a user discards changes.  
  
##  <a name="disable"></a> Disable bookmarking  
 The bookmarking feature for HTML client screens enables a user to copy the URL for a specific screen instance and return to that instance later. The URL is partially based on the primary key for the screen’s entity, so if the primary key contains sensitive information such as a SSN, you may want to prevent users from seeing it by disabling the bookmarking feature. The following code disables bookmarking by removing the entity identifier (the portion between the screen name and session ID) from the URL.  
  
#### To disable bookmarking  
  
1.  In **Solution Explorer**, under the **HTMLClient** node, choose the **default.htm** file and open it.  
  
2.  In the Code Editor, locate the line `$(document).ready(function () {` and add the following line of code immediately below it:  
  
    ```javascript  
    msls.application.options.disableUrlScreenParameters = true;  
    ```  
  
     The entity identifier will be removed from the URL, and users will no longer be able to bookmark screens.  
  
## See Also  
 [HTML Client API Reference](../VS_csharp/html-client-api-reference.md)