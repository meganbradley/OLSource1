---
title: "HTML Client API Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 90c52f9a-02c1-42aa-93d2-ee45bafaad44
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HTML Client API Reference
The article provides an overview of the generated portions of the JavaScript API for LightSwitch HTML clients.  
  
-   [Entry points for HTML client code](../vs140/html-client-api-reference.md#entry)  
  
    -   [Entity Created](../vs140/html-client-api-reference.md#created)  
  
    -   [Screen Created](../vs140/html-client-api-reference.md#screated)  
  
    -   [Screen Before Apply Changes](../vs140/html-client-api-reference.md#before)  
  
    -   [Application Save](../vs140/html-client-api-reference.md#save)  
  
    -   [Screen Methods](../vs140/html-client-api-reference.md#methods)  
  
    -   [Screen Content Render](../vs140/html-client-api-reference.md#render)  
  
    -   [Screen Content Post Render](../vs140/html-client-api-reference.md#post)  
  
-   [Generated object model](../vs140/html-client-api-reference.md#generated)  
  
    -   [msls](../vs140/html-client-api-reference.md#msls)  
  
    -   [msls.application](../vs140/html-client-api-reference.md#app)  
  
    -   [msls.BusinessObject](../vs140/html-client-api-reference.md#business)  
  
    -   [msls.CollectionChange](../vs140/html-client-api-reference.md#change)  
  
    -   [msls.CollectionChangeAction](../vs140/html-client-api-reference.md#action)  
  
    -   [msls.ContentItem](../vs140/html-client-api-reference.md#item)  
  
    -   [msls.ContentItemKind](../vs140/html-client-api-reference.md#kind)  
  
    -   [msls.DataService](../vs140/html-client-api-reference.md#service)  
  
    -   [msls.DataServiceQuery](../vs140/html-client-api-reference.md#query)  
  
    -   [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)  
  
    -   [msls.Entity](../vs140/html-client-api-reference.md#entity)  
  
    -   [msls.EntityCollection](../vs140/html-client-api-reference.md#collection)  
  
    -   [msls.EntitySet](../vs140/html-client-api-reference.md#set)  
  
    -   [msls.EntityState](../vs140/html-client-api-reference.md#state)  
  
    -   [msls.HeightSizingMode](../vs140/html-client-api-reference.md#height)  
  
    -   [msls.HorizontalAlignment](../vs140/html-client-api-reference.md#horizontal)  
  
    -   [msls.MergeOperation](../vs140/html-client-api-reference.md#merge)  
  
    -   [msls.MessageBoxButtons](../vs140/html-client-api-reference.md#buttons)  
  
    -   [msls.MessageBoxResults](../vs140/html-client-api-reference.md#result)  
  
    -   [msls.NavigateBackAction](../vs140/html-client-api-reference.md#back)  
  
    -   [msls.ObjectWithDetails](../vs140/html-client-api-reference.md#object)  
  
    -   [msls.PageKind](../vs140/html-client-api-reference.md#page)  
  
    -   [msls.Screen](../vs140/html-client-api-reference.md#screen)  
  
    -   [msls.Sequence](../vs140/html-client-api-reference.md#sequence)  
  
    -   [msls.TransitionAnimationLevel](../vs140/html-client-api-reference.md#transition)  
  
    -   [msls.ValidationResult](../vs140/html-client-api-reference.md#validation)  
  
    -   [msls.VisualCollection](../vs140/html-client-api-reference.md#visual)  
  
    -   [msls.WidthSizingMode](../vs140/html-client-api-reference.md#width)  
  
##  \<a name="entry">\</a> Entry points for HTML client code  
 Each entity and screen, and the app itself, exposes the following entry points where you can write custom JavaScript code for your app.  
  
-   [Entity Created](../vs140/html-client-api-reference.md#created)  
  
-   [Screen Created](../vs140/html-client-api-reference.md#screated)  
  
-   [Screen Before Apply Changes](../vs140/html-client-api-reference.md#before)  
  
-   [Application Save](../vs140/html-client-api-reference.md#save)  
  
-   [Screen Methods](../vs140/html-client-api-reference.md#methods)  
  
-   [Screen Content Render](../vs140/html-client-api-reference.md#render)  
  
-   [Screen Content Post Render](../vs140/html-client-api-reference.md#post)  
  
###  \<a name="created">\</a> Entity Created  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 This method is called when an entity is created. The entity object creates a generated property for each property listed in the entity designer.  
  
 It is typically used to set global property values for an entity. The following example sets the initial value for a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Insured property of a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> entity:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To access this entry point, open the designer for the entity, and choose the **HTMLClient** perspective. In the **Write Code** list, choose **created**.  
  
###  \<a name="screated">\</a> Screen Created  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 This method is called each time a screen is created.  
  
 It is typically used to set initial values for fields on a screen. The following example sets the value for the **State** field on a **AddEditPatient** screen:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To access this entry point, open the designer for the screen. In the **Write Code** list, choose **created**.  
  
###  \<a name="before">\</a> Screen Before Apply Changes  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 This method is called each time a save operation is initiated for a screen. If the method returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the save operation proceeds. If it returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the save operation is canceled.  If the method returns a **WinJs.Promise** object, the save operation waits for the promise to complete (or fail) before continuing.  
  
 It is typically used for screen validation logic. The following example validates the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> field:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To access this entry point, open the designer for the screen. In the **Write Code** list, choose **beforeApplyChanges**.  
  
###  \<a name="save">\</a> Application Save  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 This method is called when a save operation takes place, after the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 It is typically used to add logic to the save operation, for example, when saving to multiple data sources. The following example uses the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to customize the built-in **Save** command.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To access this entry point, open the designer for the screen, and then choose **Write Code**.  
  
###  \<a name="methods">\</a> Screen Methods  
 Each screen method that is listed in the screen members list of the screen designer has two methods available: <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method is typically used to perform a function when a user clicks a button. The **canExecute** method is typically used to enable or disable a button based on a condition.  
  
-   Method signature: <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
     Executed when the *MyMethod* button is clicked or when the *MyScreen.MyMethod()* method is called from code.  
  
     The following example deletes the selected <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> screen:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Method signature: <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
     Called before a method runs.  If this function returns <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, the *MyMethod* button will be disabled. If it returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the button will be enabled.  
  
     The following example disables a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> button for a record that hasn’t been saved yet.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 To access screen methods, open the shortcut menu for the method in the left pane of the screen designer, and then choose the method.  
  
###  \<a name="render">\</a> Screen Content Render  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 This method is called when a screen is created and applies only to custom controls. It is typically used to render the contents of the control on the screen.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is the HTML element for the control. Use <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to create a jQuery object.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object that allows access to the item’s value, databinding, and validation results.  
  
 The following example displays an <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> for each row in a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> control:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To access the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method, choose a custom control in the screen designer. In the **Write Code** list, choose *ControlName_***render**.  
  
###  \<a name="post">\</a> Screen Content Post Render  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
 This method is called after a screen is created or refreshed. It is typically used to modify the contents or appearance of a control on the screen.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is the HTML element for the control. Use <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to create a Jquery object.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object that allows access to the item’s value, databinding, and validation results.  
  
 The following example formats a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to display two decimal places in a control named <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To access the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> method, choose a control in the screen designer. In the **Write Code** list, choose *ControlName_***postRender**.  
  
##  \<a name="generated">\</a> Generated object model  
 LightSwitch generates a custom API set based on project assets that you can use when writing custom code in the HTML client. Each data source, table, query and screen generates various items in the API set.  
  
-   [msls](../vs140/html-client-api-reference.md#msls)  
  
-   [msls.application](../vs140/html-client-api-reference.md#app)  
  
-   [msls.BusinessObject](../vs140/html-client-api-reference.md#business)  
  
-   [msls.CollectionChange](../vs140/html-client-api-reference.md#change)  
  
-   [msls.CollectionChangeAction](../vs140/html-client-api-reference.md#action)  
  
-   [msls.ContentItem](../vs140/html-client-api-reference.md#item)  
  
-   [msls.ContentItemKind](../vs140/html-client-api-reference.md#kind)  
  
-   [msls.DataService](../vs140/html-client-api-reference.md#service)  
  
-   [msls.DataServiceQuery](../vs140/html-client-api-reference.md#query)  
  
-   [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)  
  
-   [msls.Entity](../vs140/html-client-api-reference.md#entity)  
  
-   [msls.EntityCollection](../vs140/html-client-api-reference.md#collection)  
  
-   [msls.EntitySet](../vs140/html-client-api-reference.md#set)  
  
-   [msls.EntityState](../vs140/html-client-api-reference.md#state)  
  
-   [msls.HeightSizingMode](../vs140/html-client-api-reference.md#height)  
  
-   [msls.HorizontalAlignment](../vs140/html-client-api-reference.md#horizontal)  
  
-   [msls.MergeOperation](../vs140/html-client-api-reference.md#merge)  
  
-   [msls.MessageBoxButtons](../vs140/html-client-api-reference.md#buttons)  
  
-   [msls.MessageBoxResults](../vs140/html-client-api-reference.md#result)  
  
-   [msls.NavigateBackAction](../vs140/html-client-api-reference.md#back)  
  
-   [msls.ObjectWithDetails](../vs140/html-client-api-reference.md#object)  
  
-   [msls.PageKind](../vs140/html-client-api-reference.md#page)  
  
-   [msls.Screen](../vs140/html-client-api-reference.md#screen)  
  
-   [msls.Sequence](../vs140/html-client-api-reference.md#sequence)  
  
-   [msls.TransitionAnimationLevel](../vs140/html-client-api-reference.md#transition)  
  
-   [msls.ValidationResult](../vs140/html-client-api-reference.md#validation)  
  
-   [msls.VisualCollection](../vs140/html-client-api-reference.md#visual)  
  
-   [msls.WidthSizingMode](../vs140/html-client-api-reference.md#width)  
  
##  \<a name="msls">\</a> msls  
 (global variable) msls  
  
 **Members**  
  
-   [_run](../vs140/html-client-api-reference.md#run)  
  
-   [promiseOperation](../vs140/html-client-api-reference.md#promise)  
  
-   [relativeDates](../vs140/html-client-api-reference.md#relative)  
  
-   [relativeDateTimeOffsets](../vs140/html-client-api-reference.md#offset)  
  
-   [render](../vs140/html-client-api-reference.md#rend)  
  
-   [showMessageBox](../vs140/html-client-api-reference.md#message)  
  
-   [showProgress](../vs140/html-client-api-reference.md#progress)  
  
###  \<a name="run">\</a> _run  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 Asynchronously launches the LightSwitch application. This method is called in the default.html file for the application.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="promise">\</a> promiseOperation  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
 Initiates a new operation and returns a promise object when that operation is complete.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
###  \<a name="relative">\</a> relativeDates  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
 Contains the implementation of globally defined relative dates.  
  
 Return type: [Date](http://msdn.microsoft.com/library/cd9w2te4\(v=vs.94\).aspx)  
  
 Methods that start with "end" return a time of 23:59:59.  Methods that start with "start" return a time of 00:00:00.  
  
|Method|Returns|  
|------------|-------------|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|The date and time for the end of the current day.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|The date and time for the end of the current month.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|The date and time for the end of the current quarter.|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|The date and time for the end of the current week.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|The date and time for the end of the current year.|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|The current date and time.|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|The date and time for the start of the current month.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|The date and time for the start of the current quarter.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|The date and time for the start of the current week.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|The date and time for the start of the current year.|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|The current date with a time of 00:00:00.|  
  
 The following code example returns the related <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> values for a given date:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
###  \<a name="offset">\</a> relativeDateTimeOffsets  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 Contains the implementation of globally defined relative dates using the offset from Coordinated Universal Time (UTC).  
  
 Return type: [Date](http://msdn.microsoft.com/library/cd9w2te4\(v=vs.94\).aspx)  
  
 Methods that start with "end" return a time of 23:59:59.  Methods that start with "start" return a time of 00:00:00.  
  
|Method|Returns|  
|------------|-------------|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|The date and time for the end of the current day.|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|The date and time for the end of the current month.|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|The date and time for the end of the current quarter.|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|The date and time for the end of the current week.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|The date and time for the end of the current year.|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|The current date and time.|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|The date and time for the start of the current month.|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|The date and time for the start of the current quarter.|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|The date and time for the start of the current week.|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|The date and time for the start of the current year.|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|The current date with a time of 00:00:00.|  
  
###  \<a name="rend">\</a> render  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
 Renders the visualization of a content item inside a root HTML element.  
  
 Example:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
###  \<a name="message">\</a> showMessageBox  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
 Displays a message box to the user.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 A promise is returned when the user closes the message box. You can access the result of the message box (of type [msls.MessageBoxResults](../vs140/html-client-api-reference.md#result)) through the returned promise.  
  
 Options:  
  
|Parameter|Description|Default|  
|---------------|-----------------|-------------|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|A title for the message box.|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> value that specifies the buttons to show.|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
  
 Example:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
###  \<a name="progress">\</a> showProgress  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
 Shows a progress indicator that prevents the usage of the application until a promise is resolved or rejected.  
  
 Example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="app">\</a> msls.application  
 Represents the active LightSwitch application.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object is a shortcut for <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
-   [activeDataWorkspace](../vs140/html-client-api-reference.md#active)  
  
-   [applyChanges](../vs140/html-client-api-reference.md#apply)  
  
-   [cancelChanges](../vs140/html-client-api-reference.md#cancel)  
  
-   [commitChanges](../vs140/html-client-api-reference.md#commit)  
  
-   [navigateBack](../vs140/html-client-api-reference.md#navigateBack)  
  
-   [navigateHome](../vs140/html-client-api-reference.md#navigateHome)  
  
-   [options](../vs140/html-client-api-reference.md#options)  
  
-   [showScreen](../vs140/html-client-api-reference.md#showScreen)  
  
###  \<a name="active">\</a> activeDataWorkspace  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
 Gets the current workspace for the application.  
  
 Example:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
###  \<a name="apply">\</a> applyChanges  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
 Asynchronously applies any pending changes by merging nested changes into the parent change set or saving top-level changes, and stays on the current screen. Calling <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> saves all the changes of the current change set. If only one change set exists, it saves the changes to the data source. If the current change set is a nested scope, it commits the changes to the parent change set.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
###  \<a name="cancel">\</a> cancelChanges  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 Undoes all changes in the current change set and navigates back to the previous screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
###  \<a name="commit">\</a> commitChanges  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
 Asynchronously commits any pending changes by merging nested changes into the parent change set or saving top-level changes, and then navigates back to the previous screen. Calling <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> saves all the changes of the current change set, just like <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. First validation is run on the screen, and if there are no errors, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is called.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
###  \<a name="navigateBack">\</a> navigateBack  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
 Prompts the user to commit or cancel any pending changes and to either navigate back to the previous screen, or to stay on the current screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="navigateHome">\</a> navigateHome  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 Asynchronously navigates forward to the home screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="options">\</a> options  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 Gets the values of options that affect the LightSwitch application. Options must be set in the default.htm file, before calling <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
|Option|Type|Description|  
|------------|----------|-----------------|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|Specifies how to merge the results of queries with locally cached data. This can be set to a value of [msls.MergeOption](../vs140/html-client-api-reference.md#merge).|  
|<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>|Specifies whether a primary key is used to form the URL for a screen instance. The bookmarking feature for HTML client screens enables a user to copy the URL for a specific screen instance and return to that instance later. The URL is partially based on the primary key for the screen’s entity, so if the primary key contains sensitive information you may want to prevent users from seeing it by disabling the bookmarking feature.|  
|<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>|Indicates whether to use an independent scroll region inside modal views such as dialog boxes and pickers. If this option isn't enabled, modal views will expand to their full size, allowing the user to scroll in the main browser window to see all the content. This option works better with some devices.|  
|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|Indicates whether the background screen behind a dialog box should be visible. This has no effect on small devices, because a dialog box always uses the entire display. Hiding the background screen on large devices may improve performance.|  
|<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|Specifies the level of animation that occurs during transitions. A simple animation can improve performance on some devices. This option can be set to a value of [msls.TransitionAnimationLevel](../vs140/html-client-api-reference.md#transition).|  
  
###  \<a name="showScreen">\</a> showScreen  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  
 Asynchronously navigates forward to a specific screen.  
  
 Parameter <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>: The modeled name of a screen or the model item that defines a screen.  
  
 Optional parameter <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>: An array of screen parameters, if applicable.  
  
 Optional parameter <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>: An object that provides one or more of the following options:  
  
-   <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>: A function that is called after boundary behavior has been applied but before the screen is shown.  
  
-   <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>: A function that is called after boundary behavior has been applied and the screen has been closed.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="business">\</a> msls.BusinessObject  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
  
 Represents a business object.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|Represents the details for a business object.|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|Gets the business object that owns this details object.|[msls.BusinessObject](../vs140/html-client-api-reference.md#business)|  
|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>|Gets the set of property objects for the owner's properties.|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|  
  
##  \<a name="change">\</a> msls.CollectionChange  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
  
 Provides data for the collection change event.  
  
 Parameter <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>: The action of type [msls.CollectionChangeAction](../vs140/html-client-api-reference.md#action) that caused the event.  
  
 Optional parameter <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>: The array of items (collection) affected by the action.  
  
 Optional parameter <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>: The index at which the items were removed, if applicable.  
  
 Optional parameter <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>: The index at which the items were added, if applicable.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|Gets the description of the action that caused the event.|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|Gets the array of items affected by the action.|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|Gets the index at which the items were added, if applicable.|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|Gets the index at which the items were removed, if applicable.|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|  
  
##  \<a name="action">\</a> msls.CollectionChangeAction  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
  
 Specifies how a collection has changed.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|Specifies that items were added to the collection.|  
|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|Specifies that the entire collection has changed.|  
|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|Specifies that items were removed from the collection.|  
  
##  \<a name="item">\</a> msls.ContentItem  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
  
 Represents the view model for an item of content that is visualized by a screen. <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is available as the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> argument in the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> methods.  
  
 Parameter <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>: The screen (of type [msls.Screen](../vs140/html-client-api-reference.md#screen)) that owns this content item.  
  
 Parameter <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>: The modeled definition of this content item.  
  
 **Properties**  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>: Gets the application object to which the item belongs. Type: [msls.application](../vs140/html-client-api-reference.md#app).  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>: Gets the binding path between the "data" property (the source) and the "value" property (the target). Type: <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>: Gets the child content items owned by this content item. For example, the children of a **Tab** would be all the controls shown while the tab is active. Type: Array of <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>: Gets the list of static choices for the value of this content item, if applicable. Type: Array.  
  
 Example:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>: Gets or sets a visual collection that provides a dynamic set of choices for the value of this content item. Type: [msls.VisualCollection](../vs140/html-client-api-reference.md#visual).  
  
> [!NOTE]
>  Only applies to the **Details Modal Picker** control.  
  
 The default value is <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>. At run time, the control dynamically creates a visual collection that contains every item on the server.  <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> can be updated to a more specific visual collection, like the results of a query.  Note that the control only initializes the visual collection once for performance reasons.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>: Gets the command content items owned by this content item. Type: Array of [msls.ContentItem](../vs140/html-client-api-reference.md#item).  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>: Gets the model item describing the control that is visualizing this content item. Type: <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>: Gets the source data object from which the **details** and **value** properties are bound. Type: <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>: Gets or sets the description for this content item. Type: <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>: Gets the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> property object for the value that this content item represents, using a binding path that is derived from the [bindingPath](../vs140/html-client-api-reference.md#bindingPath) property. Type: <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>: Gets the display error that occurred for the control, if any. Type: <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>: Gets or sets the display name for this content item. Type:  <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>: Gets the height sizing mode for this content item. Type: [msls.HeightSizingMode](../vs140/html-client-api-reference.md#height) (<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>: Gets the horizontal alignment of this content item. Type: [msls.HorizontalAlignment](../vs140/html-client-api-reference.md#horizontal) (<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>: Gets a value indicating if the control for this content item should be enabled. Type: <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>: Gets a value indicating if the control for this content item should be shown in the loading state. Type: <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>: Gets a value indicating if the control for this content item should be read only. Type: <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>: Gets or sets a value indicating if the control for this content item should be visible. Type: <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>: Gets the kind of this content item. Type: [msls.ContentItemKind](../vs140/html-client-api-reference.md#kind) (<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>).  
  
 Example:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>: Gets the model item that describes this content item. Type: <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>:  Gets the name of this content item. Type: <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>: Gets or sets a handler for the change event, which is called any time the value of an observable property on this object changes. Type: <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>: Gets the type of page (<CodeContentPlaceHolder>207\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>) of this content item. Type: [msls.PageKind](../vs140/html-client-api-reference.md#page) (<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>: Gets the parent content item that owns this content item. Type: [msls.ContentItem](../vs140/html-client-api-reference.md#item).  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>: Gets the set of control-specific properties used to configure the visualization of this content item. Type: <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>: Gets the screen that produced this content item. Type: [msls.Screen](../vs140/html-client-api-reference.md#screen).  
  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>: Gets or sets the string representation of the **value** property. It’s preferable to use this property instead of the <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> property when getting a value to be displayed on the screen. Type: <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>: Gets or sets the current set of validation results for this content item. Type: Array of [msls.ValidationResult](../vs140/html-client-api-reference.md#validation).  
  
 Includes any results that were explicitly set into this property, plus any results that were added by automatic validation or by calling the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> method. Note that the validation results will not be displayed until the user modifies the property in the UI or tries to save.  
  
 Example:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>: Gets or sets the value that this content item represents. Type: <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>: Gets the model item that describes the value of this content item. Type: <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>: Gets the width-sizing mode for this content item. Type: [msls.WidthSizingMode](../vs140/html-client-api-reference.md#width) (<CodeContentPlaceHolder>225\</CodeContentPlaceHolder>).  
  
 **Methods**  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>: Adds a change event listener.  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>: A property name, or null for the global change event. Type: <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>: The function to call when the change event is raised. Type: <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>: Binds to a source that is identified by a binding path (for example, <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>: A dot-delimited binding path that describes the path to the source. Type: <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>: A function that is called when the source changes. Type: <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>: Raises a change event for a property.  
  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>: A property name. Type: <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>: Recursively searches for a content item starting from this content item.  
  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>: The unique name of a content item. Type: <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>.  
  
 Returns [msls.ContentItem](../vs140/html-client-api-reference.md#item): The content item with the specified name, if found; otherwise, a false value.  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>: Sets a handler for the view dispose event.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
  
 Parameter: <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>: A function that is called when the view for this content item is disposed. Type: <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>: Indicates if this content item currently has validation errors.  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>: Indicates if child content items should also be checked. Type: <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>.  
  
 Returns <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>: true if there are validation errors; otherwise, false.  
  
 Example:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>: Removes a change event listener.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
  
 Parameter <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>: A property name, or null for the global change event. Type: <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>: The event listener that should be removed. Type: <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>.  
  
 Example:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>: Runs defined validation rules on the value property and updates the value of the **validationResults** property.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
  
 Optional parameter <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>: Indicates if child content items should also be validated. If true, the **validationResults** property on child content items are updated. Type: <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
##  \<a name="kind">\</a> msls.ContentItemKind  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
  
 Specifies the kind of a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>267\</CodeContentPlaceHolder>|Specifies a content item that binds to a visual collection.|  
|<CodeContentPlaceHolder>268\</CodeContentPlaceHolder>|Specifies a content item that binds to a command that invokes a method.|  
|<CodeContentPlaceHolder>269\</CodeContentPlaceHolder>|Specifies a content item that binds to an object such as an entity.|  
|<CodeContentPlaceHolder>270\</CodeContentPlaceHolder>|Specifies a content item that contains other content items.|  
|<CodeContentPlaceHolder>271\</CodeContentPlaceHolder>|Specifies the root content item of a popup on a screen.|  
|<CodeContentPlaceHolder>272\</CodeContentPlaceHolder>|Specifies the root content item of a screen.|  
|<CodeContentPlaceHolder>273\</CodeContentPlaceHolder>|Specifies the root content item of a tab on a screen.|  
|<CodeContentPlaceHolder>274\</CodeContentPlaceHolder>|Specifies a content item that binds to a value such as a number, date or string.|  
  
##  \<a name="service">\</a> msls.DataService  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
  
 Represents a data service.  
  
 Optional parameter <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>: The data workspace that owns this data service. Type: [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace).  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>277\</CodeContentPlaceHolder>|Gets the data service that owns this details object.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|<CodeContentPlaceHolder>278\</CodeContentPlaceHolder>|Gets the data workspace that manages the data service, if any.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|<CodeContentPlaceHolder>279\</CodeContentPlaceHolder>|Represents the details for a data service.|<CodeContentPlaceHolder>280\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>281\</CodeContentPlaceHolder>|Gets a value that indicates whether the data service has changes (that is, whether there are entities pending addition, modification or deletion).|<CodeContentPlaceHolder>282\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>283\</CodeContentPlaceHolder>|Gets or sets a handler for the <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> event, which is called any time any entity owned by the data service changes.|<CodeContentPlaceHolder>285\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>286\</CodeContentPlaceHolder>|Gets the data service that owns this details object.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|<CodeContentPlaceHolder>287\</CodeContentPlaceHolder>|Gets the set of property objects for the data service.|<CodeContentPlaceHolder>288\</CodeContentPlaceHolder>|  
  
##  \<a name="query">\</a> msls.DataServiceQuery  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
  
 Represents a data service query.  
  
 Parameter <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>: A source queryable object.  
  
 Optional parameter <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>: The root request URI if this is a root data service query (for example, a collection navigation query). Type: **String**.  
  
 Optional parameter <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>: The query parameters, if available (for example, a screen query based a query operation with parameters). Type: <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>.  
  
##  \<a name="workspace">\</a> msls.DataWorkspace  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
  
 Represents a data workspace.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>295\</CodeContentPlaceHolder>|Gets the data workspace that owns this details object.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|<CodeContentPlaceHolder>296\</CodeContentPlaceHolder>|Represents the details for a data workspace.|<CodeContentPlaceHolder>297\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>298\</CodeContentPlaceHolder>|Gets a value that indicates whether the data workspace has changes (that is, whether there are entities pending addition, modification or deletion).|<CodeContentPlaceHolder>299\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>300\</CodeContentPlaceHolder>|Gets a value that indicates whether the data workspace has any nested change sets.|<CodeContentPlaceHolder>301\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>302\</CodeContentPlaceHolder>|Represents a nested change set.||  
|<CodeContentPlaceHolder>303\</CodeContentPlaceHolder>|Gets or sets a handler for the <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> event, which is called any time any entity owned by any data service owned by this data workspace changes.|<CodeContentPlaceHolder>305\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>306\</CodeContentPlaceHolder>|Gets the data workspace that owns this details object.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|<CodeContentPlaceHolder>307\</CodeContentPlaceHolder>|Gets the set of property objects for the data workspace.|<CodeContentPlaceHolder>308\</CodeContentPlaceHolder>|  
  
##  \<a name="entity">\</a> msls.Entity  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
  
 Represents an entity.  
  
 Optional parameter <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>: An entity set that should contain this entity. Type: [msls.EntitySet](../vs140/html-client-api-reference.md#set).  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>311\</CodeContentPlaceHolder>|Represents the details for an entity.|<CodeContentPlaceHolder>312\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>313\</CodeContentPlaceHolder>|Gets the entity that owns this details object.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|<CodeContentPlaceHolder>314\</CodeContentPlaceHolder>|Gets the entity set that contains the entity.|[msls.EntitySet](../vs140/html-client-api-reference.md#set)|  
|<CodeContentPlaceHolder>315\</CodeContentPlaceHolder>|Gets the state (from [msls.EntityState](../vs140/html-client-api-reference.md#state)) of the entity.|<CodeContentPlaceHolder>316\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>317\</CodeContentPlaceHolder>|Gets a value that indicates whether the entity has edits (that is, if it was added and has been edited, or it is modified or deleted).|<CodeContentPlaceHolder>318\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>319\</CodeContentPlaceHolder>|Gets the entity that owns this details object.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|<CodeContentPlaceHolder>320\</CodeContentPlaceHolder>|Gets the set of property objects for the entity.|<CodeContentPlaceHolder>321\</CodeContentPlaceHolder>|  
  
##  \<a name="collection">\</a> msls.EntityCollection  
 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
  
 Represents a local collection of entities.  
  
 Parameter <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>: The details object for the entity that owns this entity collection. Type: <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>: An object that provides property data. Type: <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>327\</CodeContentPlaceHolder>|Gets or sets a handler for the collection change event.|<CodeContentPlaceHolder>328\</CodeContentPlaceHolder>|  
  
##  \<a name="set">\</a> msls.EntitySet  
 <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
  
 Represents an entity set.  
  
 Parameter <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>: The data service that owns this entity set. Type: [msls.DataService](../vs140/html-client-api-reference.md#service).  
  
 Parameter <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>: An entity set property entry.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>332\</CodeContentPlaceHolder>|Gets a value that indicates whether entities in this entity set can be deleted.|<CodeContentPlaceHolder>333\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>334\</CodeContentPlaceHolder>|Gets a value that indicates whether entities can be added to this entity set.|<CodeContentPlaceHolder>335\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>336\</CodeContentPlaceHolder>|Gets a value that indicates whether entities in this entity set can be modified.|<CodeContentPlaceHolder>337\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>338\</CodeContentPlaceHolder>|Gets the data service that owns this entity set.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|<CodeContentPlaceHolder>339\</CodeContentPlaceHolder>|Gets the name of this entity set.|<CodeContentPlaceHolder>340\</CodeContentPlaceHolder>|  
  
##  \<a name="state">\</a> msls.EntityState  
 <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>  
  
 Specifies the state of an entity.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>342\</CodeContentPlaceHolder>|The entity is added.|  
|<CodeContentPlaceHolder>343\</CodeContentPlaceHolder>|The entity is marked as deleted.|  
|<CodeContentPlaceHolder>344\</CodeContentPlaceHolder>|The entity is discarded.|  
|<CodeContentPlaceHolder>345\</CodeContentPlaceHolder>|The entity is modified.|  
|<CodeContentPlaceHolder>346\</CodeContentPlaceHolder>|The entity is unchanged.|  
  
##  \<a name="height">\</a> msls.HeightSizingMode  
 <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
  
 Specifies how the height of a content item is calculated.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>348\</CodeContentPlaceHolder>|Specifies that the content item height is based on the height of its content.|  
|<CodeContentPlaceHolder>349\</CodeContentPlaceHolder>|Specifies that the content item height is fixed.|  
|<CodeContentPlaceHolder>350\</CodeContentPlaceHolder>|Specifies that the content item height is based on the available height provided by its parent content item.|  
  
##  \<a name="horizontal">\</a> msls.HorizontalAlignment  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
  
 Specifies the horizontal alignment of a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>352\</CodeContentPlaceHolder>|Specifies that the content item is left-aligned.|  
|<CodeContentPlaceHolder>353\</CodeContentPlaceHolder>|Specifies that the content item is right-aligned.|  
  
##  \<a name="merge">\</a> msls.MergeOption  
 <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>  
  
 Specifies how entities that are being loaded into the data workspace are merged with entities that are already in the data workspace.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>355\</CodeContentPlaceHolder>|Entities that do not exist in the data workspace are added to the data workspace. If an entity is already in the data workspace, the current and original values of the entity's properties are not overwritten with data source values. This is the default merge option.|  
|<CodeContentPlaceHolder>356\</CodeContentPlaceHolder>|Entities that do not exist in the data workspace are added to the data workspace. If an entity is already in the data workspace and its entity state is unchanged, the current and original values of the entity's properties are overwritten with data source values.|  
  
##  \<a name="buttons">\</a> msls.MessageBoxButtons  
 <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>  
  
 Specifies the buttons to show in a message box.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>358\</CodeContentPlaceHolder>|Specifies the **OK** button.|  
|<CodeContentPlaceHolder>359\</CodeContentPlaceHolder>|Specifies the **OK** and **Cancel** buttons.|  
|<CodeContentPlaceHolder>360\</CodeContentPlaceHolder>|Specifies the **Yes** and **No** buttons.|  
|<CodeContentPlaceHolder>361\</CodeContentPlaceHolder>|Specifies the **Yes**, **No**, and **Cancel** buttons.|  
  
##  \<a name="result">\</a> msls.MessageBoxResult  
 <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>  
  
 Specifies the button in a message box that was chosen.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>363\</CodeContentPlaceHolder>|Specifies that the **Cancel** button was invoked.|  
|<CodeContentPlaceHolder>364\</CodeContentPlaceHolder>|Specifies that the **No** button was invoked.|  
|<CodeContentPlaceHolder>365\</CodeContentPlaceHolder>|Specifies that the **OK** button was invoked.|  
|<CodeContentPlaceHolder>366\</CodeContentPlaceHolder>|Specifies that the **Yes** button was invoked.|  
  
##  \<a name="back">\</a> msls.NavigateBackAction  
 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
  
 Specifies the action that was taken when navigating back from a screen.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>368\</CodeContentPlaceHolder>|Specifies that changes on the previous screen were canceled.|  
|<CodeContentPlaceHolder>369\</CodeContentPlaceHolder>|Specifies that changes on the previous screen were committed to the data source.|  
  
##  \<a name="object">\</a> msls.ObjectWithDetails  
 <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
  
 Represents an object that contains a <CodeContentPlaceHolder>371\</CodeContentPlaceHolder> object.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>372\</CodeContentPlaceHolder>|Represents the details for an object with details.|**msls.ObjectWithDetails.Details**|  
|<CodeContentPlaceHolder>373\</CodeContentPlaceHolder>|Gets or sets a handler for the change event, which is called any time the value of an observable property on this object changes.|<CodeContentPlaceHolder>374\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>375\</CodeContentPlaceHolder>|Represents the object that owns this details object.|[msls.ObjectWithDetails](../vs140/html-client-api-reference.md#object)|  
|<CodeContentPlaceHolder>376\</CodeContentPlaceHolder>|Gets the set of property objects for the owner's properties.|<CodeContentPlaceHolder>377\</CodeContentPlaceHolder>|  
  
##  \<a name="page">\</a> msls.PageKind  
 <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>  
  
 Specifies the kind of page represented by a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>379\</CodeContentPlaceHolder>|Specifies that the content item does not represent a page.|  
|<CodeContentPlaceHolder>380\</CodeContentPlaceHolder>|Specifies that the content item represents a popup that is shown using a nested boundary option.|  
|<CodeContentPlaceHolder>381\</CodeContentPlaceHolder>|Specifies that the content item represents a tab that appears in the screen tabs bar.|  
  
##  \<a name="screen">\</a> msls.Screen  
 <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
  
 Represents a screen.  
  
 Parameter <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>: The data workspace associated with the screen. Type: [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace).  
  
 Parameter <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>: The identifier of the model item that defines this screen. Type: <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>.  
  
 Optional parameter <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>: An object containing parameters to the screen. Type: <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>388\</CodeContentPlaceHolder>|Gets the data workspace that provides the screen's data.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|<CodeContentPlaceHolder>389\</CodeContentPlaceHolder>|Gets or sets the description for the screen.|<CodeContentPlaceHolder>390\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>391\</CodeContentPlaceHolder>|Represents the details for a screen.|<CodeContentPlaceHolder>392\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>393\</CodeContentPlaceHolder>|Gets or sets the display name for the screen.|<CodeContentPlaceHolder>394\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>395\</CodeContentPlaceHolder>|Gets the screen that owns this details object.|<CodeContentPlaceHolder>396\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>397\</CodeContentPlaceHolder>|Gets an array of the root content items for the screen's tabs and popups.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
|<CodeContentPlaceHolder>398\</CodeContentPlaceHolder>|Gets the set of property objects for the screen.|<CodeContentPlaceHolder>399\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>400\</CodeContentPlaceHolder>|Gets the root content item for the screen.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
|<CodeContentPlaceHolder>401\</CodeContentPlaceHolder>|Gets an array of the editable data services for the screen.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|<CodeContentPlaceHolder>402\</CodeContentPlaceHolder>|Gets the screen that owns this details object.|<CodeContentPlaceHolder>403\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>404\</CodeContentPlaceHolder>|Gets the server validation errors that occurred when the screen was last saved.|[msls.ValidationResult](../vs140/html-client-api-reference.md#validation)|  
|<CodeContentPlaceHolder>405\</CodeContentPlaceHolder>|Gets the root content item for the screen's start page.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
  
##  \<a name="sequence">\</a> msls.Sequence  
 <CodeContentPlaceHolder>406\</CodeContentPlaceHolder>  
  
 Represents a sequence.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>407\</CodeContentPlaceHolder>|Gets an array that represents this sequence.|<CodeContentPlaceHolder>408\</CodeContentPlaceHolder>|  
  
##  \<a name="transition">\</a> msls.TransitionAnimationLevel  
 <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>  
  
 Specifies the level of animation that occurs during transitions.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>410\</CodeContentPlaceHolder>|Use full-transition animations.|  
|<CodeContentPlaceHolder>411\</CodeContentPlaceHolder>|Use simpler transition animations that are less processor or power intensive.|  
  
##  \<a name="validation">\</a> msls.ValidationResult  
 <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>  
  
 Represents a validation result.  
  
 Parameter <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>: A property to associate with the validation result. Type: <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>: A message that describes the validation error. Type: <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>417\</CodeContentPlaceHolder>|Gets a message that describes the validation error.|<CodeContentPlaceHolder>418\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>419\</CodeContentPlaceHolder>|Gets the property on which the validation error occurred.|<CodeContentPlaceHolder>420\</CodeContentPlaceHolder>|  
  
##  \<a name="visual">\</a> msls.VisualCollection  
 <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>  
  
 Represents a collection of data that is shown by a screen.  
  
 Parameter <CodeContentPlaceHolder>422\</CodeContentPlaceHolder>: The screen details object that owns the screen collection property whose value is this collection. Type: <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>.  
  
 Parameter <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>: An object that is used to load data into the collection.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|<CodeContentPlaceHolder>425\</CodeContentPlaceHolder>|Gets a value that indicates whether this collection is able to load more pages of data.|<CodeContentPlaceHolder>426\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>427\</CodeContentPlaceHolder>|Gets the number of items that are currently in this collection.|<CodeContentPlaceHolder>428\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>429\</CodeContentPlaceHolder>|Gets the items that are currently in this collection.|<CodeContentPlaceHolder>430\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>431\</CodeContentPlaceHolder>|Gets a value that indicates whether this collection has loaded one or more pages of data.|<CodeContentPlaceHolder>432\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>433\</CodeContentPlaceHolder>|Gets the last load error that occurred, or returns null if no error occurred.|<CodeContentPlaceHolder>434\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>435\</CodeContentPlaceHolder>|Gets the screen that owns this collection.|[msls.Screen](../vs140/html-client-api-reference.md#screen)|  
|<CodeContentPlaceHolder>436\</CodeContentPlaceHolder>|Gets or sets the currently selected item.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|<CodeContentPlaceHolder>437\</CodeContentPlaceHolder>|Gets the current state (from <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>) of this collection.|<CodeContentPlaceHolder>439\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>440\</CodeContentPlaceHolder> values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>441\</CodeContentPlaceHolder>|Specifies that the visual collection is not currently loading data.|  
|<CodeContentPlaceHolder>442\</CodeContentPlaceHolder>|Specifies that the visual collection is currently loading data.|  
|<CodeContentPlaceHolder>443\</CodeContentPlaceHolder>|Specifies that the visual collection is currently loading more data.|  
  
##  \<a name="width">\</a> msls.WidthSizingMode  
 <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>  
  
 Specifies how the width of a content item is calculated.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>445\</CodeContentPlaceHolder>|Specifies that the content item width is based on the width of its content.|  
|<CodeContentPlaceHolder>446\</CodeContentPlaceHolder>|Specifies that the content item width is fixed.|  
|<CodeContentPlaceHolder>447\</CodeContentPlaceHolder>|Specifies that the content item width is based on the available width provided by its parent content item.|  
  
## See Also  
 [How to: Handle Screen Events in a Mobile Client for a LightSwitch App](../vs140/how-to--handle-screen-events-in-a-mobile-client-for-a-lightswitch-app.md)   
 [How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md)   
 [HTML Client Screens for LightSwitch Apps](../vs140/html-client-screens-for-lightswitch-apps.md)