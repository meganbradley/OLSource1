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
  
##  \<a name="entry"></a> Entry points for HTML client code  
 Each entity and screen, and the app itself, exposes the following entry points where you can write custom JavaScript code for your app.  
  
-   [Entity Created](../vs140/html-client-api-reference.md#created)  
  
-   [Screen Created](../vs140/html-client-api-reference.md#screated)  
  
-   [Screen Before Apply Changes](../vs140/html-client-api-reference.md#before)  
  
-   [Application Save](../vs140/html-client-api-reference.md#save)  
  
-   [Screen Methods](../vs140/html-client-api-reference.md#methods)  
  
-   [Screen Content Render](../vs140/html-client-api-reference.md#render)  
  
-   [Screen Content Post Render](../vs140/html-client-api-reference.md#post)  
  
###  \<a name="created"></a> Entity Created  
 `myapp.[EntityName].created = function (entity) {};`  
  
 This method is called when an entity is created. The entity object creates a generated property for each property listed in the entity designer.  
  
 It is typically used to set global property values for an entity. The following example sets the initial value for a `Boolean`Insured property of a `Patient` entity:  
  
```javascript  
myapp.Patient.created = function (entity) {  
    entity.Insured = new Boolean();  
    entity.Insured = 'true';  
};  
```  
  
 To access this entry point, open the designer for the entity, and choose the **HTMLClient** perspective. In the **Write Code** list, choose **created**.  
  
###  \<a name="screated"></a> Screen Created  
 `myapp.[ScreenName].created = function (screen) {}`  
  
 This method is called each time a screen is created.  
  
 It is typically used to set initial values for fields on a screen. The following example sets the value for the **State** field on a **AddEditPatient** screen:  
  
```javascript  
myapp.AddEditPatient.created = function (screen) {  
   screen.Patient.State = 'CA'  
};  
```  
  
 To access this entry point, open the designer for the screen. In the **Write Code** list, choose **created**.  
  
###  \<a name="before"></a> Screen Before Apply Changes  
 `myapp.[ScreenName].beforeApplyChanges = function (screen) {};`  
  
 This method is called each time a save operation is initiated for a screen. If the method returns `true`, the save operation proceeds. If it returns `false`, the save operation is canceled.  If the method returns a **WinJs.Promise** object, the save operation waits for the promise to complete (or fail) before continuing.  
  
 It is typically used for screen validation logic. The following example validates the `PatientName` field:  
  
```javascript  
myapp.AddEditPatient.beforeApplyChanges = function (screen) {  
    if (screen.Patient.PatientName.indexOf('!') != -1) {  
        screen.findContentItem("PatientName").validationResults = [  
        new msls.ValidationResult(  
        screen.Patient.details.properties.PatientName,  
        "Patient Name cannot contain the character '!'.")  
        ];  
        return false;  
    }  
};  
```  
  
 To access this entry point, open the designer for the screen. In the **Write Code** list, choose **beforeApplyChanges**.  
  
###  \<a name="save"></a> Application Save  
 `myapp.onsavechanges = function () {}`  
  
 This method is called when a save operation takes place, after the `beforeApplyChanges` method returns `true`.  
  
 It is typically used to add logic to the save operation, for example, when saving to multiple data sources. The following example uses the `WinJs.Promise` object to customize the built-in **Save** command.  
  
```javascript  
myapp.onsavechanges = function (e) {  
    var promises = [];  
    promises.push(myapp.activeDataWorkspace.NorthwindData.saveChanges());  
    promises.push(myapp.activeDataWorkspace.ApplicationData.saveChanges());  
    e.detail.promise = WinJS.Promise.join(promises);  
};  
```  
  
 To access this entry point, open the designer for the screen, and then choose **Write Code**.  
  
###  \<a name="methods"></a> Screen Methods  
 Each screen method that is listed in the screen members list of the screen designer has two methods available: `execute` and `canExecute`. The `execute` method is typically used to perform a function when a user clicks a button. The **canExecute** method is typically used to enable or disable a button based on a condition.  
  
-   Method signature: `myapp.MyScreen.MyMethod_execute = function (screen) { };`  
  
     Executed when the *MyMethod* button is clicked or when the *MyScreen.MyMethod()* method is called from code.  
  
     The following example deletes the selected `Customer` on a `BrowseCustomers` screen:  
  
    ```javascript  
    myapp.BrowseCustomers.DeleteSelected_execute = function (screen) {  
        screen.getCustomers().then(function (customers) {  
            customers.deleteSelected();  
        });  
    };  
    ```  
  
-   Method signature: `myapp.MyScreen.MyMethod_canExecute = function (screen) { };`  
  
     Called before a method runs.  If this function returns `false`, the *MyMethod* button will be disabled. If it returns `true`, the button will be enabled.  
  
     The following example disables a `Delete` button for a record that hasn’t been saved yet.  
  
    ```javascript  
    myapp.MyScreen.Delete_canExecute = function (screen) {  
        return (screen.MyEntity.Id != null);  
    };  
    ```  
  
 To access screen methods, open the shortcut menu for the method in the left pane of the screen designer, and then choose the method.  
  
###  \<a name="render"></a> Screen Content Render  
 `myapp.[ScreenName].[ContentItemName]_render = function (element, contentItem)`  
  
 This method is called when a screen is created and applies only to custom controls. It is typically used to render the contents of the control on the screen.  
  
 `element` is the HTML element for the control. Use `$(element)` to create a jQuery object.  
  
 `contentItem` is an `msls.ContentItem` object that allows access to the item’s value, databinding, and validation results.  
  
 The following example displays an `OrderDate` for each row in a `RowTemplate` control:  
  
```javascript  
myapp.BrowseOrders.RowTemplate_render = function (element, contentItem) {   
 var orderDate = $("<p>" + contentItem.value.OrderDate + "</p>");   
 orderDate.appendTo($(element));   
};  
```  
  
 To access the `render` method, choose a custom control in the screen designer. In the **Write Code** list, choose *ControlName_***render**.  
  
###  \<a name="post"></a> Screen Content Post Render  
 `myapp.BrowseTable1Items.ContentItem2_postRender = function (element, contentItem) {};`  
  
 This method is called after a screen is created or refreshed. It is typically used to modify the contents or appearance of a control on the screen.  
  
 `element` is the HTML element for the control. Use `$(element)` to create a Jquery object.  
  
 `contentItem` is an `msls.ContentItem` object that allows access to the item’s value, databinding, and validation results.  
  
 The following example formats a `Double` to display two decimal places in a control named `Unit`:  
  
```javascript  
myapp.ViewItems.Unit_postRender = function (element, contentItem) {  
    contentItem.dataBind("value", function (value) {  
        if (value) {  
            $(element).text(value.toFixed(2));  
        }  
    });  
}  
```  
  
 To access the `postRender` method, choose a control in the screen designer. In the **Write Code** list, choose *ControlName_***postRender**.  
  
##  \<a name="generated"></a> Generated object model  
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
  
##  \<a name="msls"></a> msls  
 (global variable) msls  
  
 **Members**  
  
-   [_run](../vs140/html-client-api-reference.md#run)  
  
-   [promiseOperation](../vs140/html-client-api-reference.md#promise)  
  
-   [relativeDates](../vs140/html-client-api-reference.md#relative)  
  
-   [relativeDateTimeOffsets](../vs140/html-client-api-reference.md#offset)  
  
-   [render](../vs140/html-client-api-reference.md#rend)  
  
-   [showMessageBox](../vs140/html-client-api-reference.md#message)  
  
-   [showProgress](../vs140/html-client-api-reference.md#progress)  
  
###  \<a name="run"></a> _run  
 `_run([homeScreenId : String])`  
  
 Asynchronously launches the LightSwitch application. This method is called in the default.html file for the application.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="promise"></a> promiseOperation  
 `promiseOperation(init(operations), [independent: Boolean])`  
  
 Initiates a new operation and returns a promise object when that operation is complete.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
```javascript  
//Method that imports data from Northwind.svc  
myapp.BrowseOrders.ImportOrders_execute = function (screen) {   
    var northwind = "http://services.odata.org/Northwind/Northwind.svc";   
    return msls.promiseOperation(function (operation) {   
        OData.read({ requestUri: northwind + "/Orders?$top=10",   
            recognizeDates: true,   
            enableJsonpCallback: true },   
                     function success(result) {   
                         var results = result.results;   
                         for (var i = 0, len = results.length; i < len; i++) {   
                             var importedOrder = screen.Orders.addNew();   
                             importedOrder.OrderDate = results[i].OrderDate;   
                         }    
                         operation.complete();   
                     },   
                     function error(e) { operation.error(e); });   
    });   
};  
```  
  
###  \<a name="relative"></a> relativeDates  
 `relativeDates`  
  
 Contains the implementation of globally defined relative dates.  
  
 Return type: [Date](http://msdn.microsoft.com/library/cd9w2te4\(v=vs.94\).aspx)  
  
 Methods that start with "end" return a time of 23:59:59.  Methods that start with "start" return a time of 00:00:00.  
  
|Method|Returns|  
|------------|-------------|  
|`endOfDay()`|The date and time for the end of the current day.|  
|`endOfMonth()`|The date and time for the end of the current month.|  
|`endOfQuarter()`|The date and time for the end of the current quarter.|  
|`endOfWeek()`|The date and time for the end of the current week.|  
|`endOfYear()`|The date and time for the end of the current year.|  
|`now()`|The current date and time.|  
|`startOfMonth()`|The date and time for the start of the current month.|  
|`startOfQuarter()`|The date and time for the start of the current quarter.|  
|`startOfWeek()`|The date and time for the start of the current week.|  
|`startOfYear()`|The date and time for the start of the current year.|  
|`today()`|The current date with a time of 00:00:00.|  
  
 The following code example returns the related `startOfWeek` and `endOfWeek` values for a given date:  
  
```javascript  
myapp.AddEditAppointment.created = function (screen) {  
    // Write code here.   
    var currDT = new Date();  
    ws = msls.relativeDates.startOfWeek(currDT);  
    we = msls.relativeDates.endOfWeek(currDT);  
    screen.Appointment.StartDate = ws;  
    screen.Appointment.EndDate = we;  
}  
```  
  
###  \<a name="offset"></a> relativeDateTimeOffsets  
 `relativeDateTimeOffsets`  
  
 Contains the implementation of globally defined relative dates using the offset from Coordinated Universal Time (UTC).  
  
 Return type: [Date](http://msdn.microsoft.com/library/cd9w2te4\(v=vs.94\).aspx)  
  
 Methods that start with "end" return a time of 23:59:59.  Methods that start with "start" return a time of 00:00:00.  
  
|Method|Returns|  
|------------|-------------|  
|`endOfDay()`|The date and time for the end of the current day.|  
|`endOfMonth()`|The date and time for the end of the current month.|  
|`endOfQuarter()`|The date and time for the end of the current quarter.|  
|`endOfWeek()`|The date and time for the end of the current week.|  
|`endOfYear()`|The date and time for the end of the current year.|  
|`now()`|The current date and time.|  
|`startOfMonth()`|The date and time for the start of the current month.|  
|`startOfQuarter()`|The date and time for the start of the current quarter.|  
|`startOfWeek()`|The date and time for the start of the current week.|  
|`startOfYear()`|The date and time for the start of the current year.|  
|`today()`|The current date with a time of 00:00:00.|  
  
###  \<a name="rend"></a> render  
 `render(element: HTMLElement, contentItem: msls.ContentItem)`  
  
 Renders the visualization of a content item inside a root HTML element.  
  
 Example:  
  
```javascript  
myapp.BrowseOrders.RowTemplate_render = function (element, contentItem) {  
    var orderDate = $("<p>").text(contentItem.value.Customer.CompanyName);  
    orderDate.appendTo($(element));  
};  
```  
  
###  \<a name="message"></a> showMessageBox  
 `showMessageBox(message:String, [options])`  
  
 Displays a message box to the user.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 A promise is returned when the user closes the message box. You can access the result of the message box (of type [msls.MessageBoxResults](../vs140/html-client-api-reference.md#result)) through the returned promise.  
  
 Options:  
  
|Parameter|Description|Default|  
|---------------|-----------------|-------------|  
|`title`|A title for the message box.|`none`|  
|`buttons`|A `msls.MessageBoxButtons` value that specifies the buttons to show.|`ok`|  
  
 Example:  
  
```javascript  
myapp.AddEditCustomer.Delete_execute = function (screen) {  
    msls.showMessageBox("Are You Sure?", {  
        title: "Delete Customer",  
    buttons: msls.MessageBoxButtons.yesNo  
}).then(function (val) {  
    if (val == msls.MessageBoxResult.yes) {  
        screen.Customer.deleteEntity();  
        myapp.commitChanges().then(null, function fail(e) {  
            var errmsg = screen.Customer.Name + e.message;  
            myapp.cancelChanges().then(function () {  
  
                var resp = msls.showMessageBox(errmsg, {  
                    title: "ERROR",  
                    buttons: msls.MessageBoxButtons.ok  
                });  
  
                throw e;  
            });  
  
        });  
    }  
});  
};  
```  
  
###  \<a name="progress"></a> showProgress  
 `showProgress(promise: WinJS.Promise)`  
  
 Shows a progress indicator that prevents the usage of the application until a promise is resolved or rejected.  
  
 Example:  
  
```javascript  
msls.showProgress(msls.promiseOperation(function (operation) {  
        $.getJSON(url, function (data) {  
            operation.complete(data); //Operation completed successfully  
        }).error(function (args) {  
            operation.error(args); //Operation completed with error.  
        });  
    }) .then(function (result) {  
        msls.showMessageBox(result);  
    })  
);  
```  
  
##  \<a name="app"></a> msls.application  
 Represents the active LightSwitch application.  
  
> [!NOTE]
>  The `myapp` object is a shortcut for `msls.application`.  
  
 `Members`  
  
-   [activeDataWorkspace](../vs140/html-client-api-reference.md#active)  
  
-   [applyChanges](../vs140/html-client-api-reference.md#apply)  
  
-   [cancelChanges](../vs140/html-client-api-reference.md#cancel)  
  
-   [commitChanges](../vs140/html-client-api-reference.md#commit)  
  
-   [navigateBack](../vs140/html-client-api-reference.md#navigateBack)  
  
-   [navigateHome](../vs140/html-client-api-reference.md#navigateHome)  
  
-   [options](../vs140/html-client-api-reference.md#options)  
  
-   [showScreen](../vs140/html-client-api-reference.md#showScreen)  
  
###  \<a name="active"></a> activeDataWorkspace  
 `msls.application.activeDataWorkspace`  
  
 Gets the current workspace for the application.  
  
 Example:  
  
```javascript  
msls.application.activeDataWorkspace.ApplicationData.Query1("parameter value")  
.execute().then(  
        function (results) {  
            if (results.results.length >= 0) {  
                msls.showMessageBox("Found some records!");  
            }  
        },  
        function (error) {  
            alert(error);  
        }  
    );  
```  
  
###  \<a name="apply"></a> applyChanges  
 `msls.application.applyChanges()`  
  
 Asynchronously applies any pending changes by merging nested changes into the parent change set or saving top-level changes, and stays on the current screen. Calling `applyChanges` saves all the changes of the current change set. If only one change set exists, it saves the changes to the data source. If the current change set is a nested scope, it commits the changes to the parent change set.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
```javascript  
// Save changes  
msls.application.applyChanges().then(null, function fail(e) {  
  
    // If an error occurs, show the error.  
    msls.showMessageBox(e.message, { title: e.title }).then(function () {  
        // Discard changes  
        screen.details.dataWorkspace.ApplicationData.details.discardChanges();  
    });  
});  
```  
  
###  \<a name="cancel"></a> cancelChanges  
 `msls.application.cancelChanges()`  
  
 Undoes all changes in the current change set and navigates back to the previous screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
```javascript  
msls.application.commitChanges().then(null, function fail(e) {  
    alert(e.message);  
    msls.application.cancelChanges();  
    throw e;  
});  
```  
  
###  \<a name="commit"></a> commitChanges  
 `msls.application.commitChanges()`  
  
 Asynchronously commits any pending changes by merging nested changes into the parent change set or saving top-level changes, and then navigates back to the previous screen. Calling `commitChanges` saves all the changes of the current change set, just like `applyChanges`. First validation is run on the screen, and if there are no errors, `saveChanges` is called.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
```javascript  
msls.application.commitChanges().then(null, function fail(e) {  
    alert(e.message);  
    msls.application.cancelChanges();  
    throw e;  
});  
```  
  
###  \<a name="navigateBack"></a> navigateBack  
 `msls.application.navigateBack()`  
  
 Prompts the user to commit or cancel any pending changes and to either navigate back to the previous screen, or to stay on the current screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="navigateHome"></a> navigateHome  
 `msls.application.navigateHome()`  
  
 Asynchronously navigates forward to the home screen.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
###  \<a name="options"></a> options  
 `msls.application.options`  
  
 Gets the values of options that affect the LightSwitch application. Options must be set in the default.htm file, before calling `msls._run`.  
  
|Option|Type|Description|  
|------------|----------|-----------------|  
|`defaultMergeOption`|`String`|Specifies how to merge the results of queries with locally cached data. This can be set to a value of [msls.MergeOption](../vs140/html-client-api-reference.md#merge).|  
|`disableUrlScreenParameters`|`Boolean`|Specifies whether a primary key is used to form the URL for a screen instance. The bookmarking feature for HTML client screens enables a user to copy the URL for a specific screen instance and return to that instance later. The URL is partially based on the primary key for the screen’s entity, so if the primary key contains sensitive information you may want to prevent users from seeing it by disabling the bookmarking feature.|  
|`enableModalScrollRegions`|`Boolean`|Indicates whether to use an independent scroll region inside modal views such as dialog boxes and pickers. If this option isn't enabled, modal views will expand to their full size, allowing the user to scroll in the main browser window to see all the content. This option works better with some devices.|  
|`showContentBehindDialog`|`Boolean`|Indicates whether the background screen behind a dialog box should be visible. This has no effect on small devices, because a dialog box always uses the entire display. Hiding the background screen on large devices may improve performance.|  
|`transitionAnimationLevel`|`String`|Specifies the level of animation that occurs during transitions. A simple animation can improve performance on some devices. This option can be set to a value of [msls.TransitionAnimationLevel](../vs140/html-client-api-reference.md#transition).|  
  
###  \<a name="showScreen"></a> showScreen  
 `msls.application.showScreen(screenId, [Array parameters],[options])`  
  
 Asynchronously navigates forward to a specific screen.  
  
 Parameter `screenId`: The modeled name of a screen or the model item that defines a screen.  
  
 Optional parameter `parameters`: An array of screen parameters, if applicable.  
  
 Optional parameter `options`: An object that provides one or more of the following options:  
  
-   `beforeShown`: A function that is called after boundary behavior has been applied but before the screen is shown.  
  
-   `afterClosed`: A function that is called after boundary behavior has been applied and the screen has been closed.  
  
 Return type: [WinJS.Promise](http://msdn.microsoft.com/library/windows/apps/br211867.aspx)  
  
 Example:  
  
```javascript  
msls.application.showScreen(AddEditPatient, null, {  
    afterClose: function (addEditScreen, navigationAction) {  
        if (navigationAction == msls.NavigateBackAction.commit) {  
            var newPatient = addEditScreen.Patient;  
            msls.application.showViewPatient(newPatient)  
        }  
    }  
});  
```  
  
##  \<a name="business"></a> msls.BusinessObject  
 `msls.BusinessObject()`  
  
 Represents a business object.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`details`|Represents the details for a business object.|`msls.BusinessObject.Details`|  
|`owner`|Gets the business object that owns this details object.|[msls.BusinessObject](../vs140/html-client-api-reference.md#business)|  
|`properties`|Gets the set of property objects for the owner's properties.|`msls.BusinessObject.Details.PropertySet`|  
  
##  \<a name="change"></a> msls.CollectionChange  
 `msls.CollectionChange(action, [items], [oldStartingIndex], [newStartingIndex])`  
  
 Provides data for the collection change event.  
  
 Parameter `action`: The action of type [msls.CollectionChangeAction](../vs140/html-client-api-reference.md#action) that caused the event.  
  
 Optional parameter `items`: The array of items (collection) affected by the action.  
  
 Optional parameter `oldStartingIndex`: The index at which the items were removed, if applicable.  
  
 Optional parameter `newStartingIndex`: The index at which the items were added, if applicable.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`action`|Gets the description of the action that caused the event.|`String`|  
|`items`|Gets the array of items affected by the action.|`Object`|  
|`newStartingIndex`|Gets the index at which the items were added, if applicable.|`Integer`|  
|`oldStartingIndex`|Gets the index at which the items were removed, if applicable.|`Integer`|  
  
##  \<a name="action"></a> msls.CollectionChangeAction  
 `msls.CollectionChangeAction`  
  
 Specifies how a collection has changed.  
  
|Value|Description|  
|-----------|-----------------|  
|`add`|Specifies that items were added to the collection.|  
|`refresh`|Specifies that the entire collection has changed.|  
|`remove`|Specifies that items were removed from the collection.|  
  
##  \<a name="item"></a> msls.ContentItem  
 `msls.ContentItem(screenObject, model)`  
  
 Represents the view model for an item of content that is visualized by a screen. `ContentItem` is available as the `contentItem` argument in the `postRender` and `render` methods.  
  
 Parameter `screenObject`: The screen (of type [msls.Screen](../vs140/html-client-api-reference.md#screen)) that owns this content item.  
  
 Parameter `model`: The modeled definition of this content item.  
  
 **Properties**  
  
 `application`: Gets the application object to which the item belongs. Type: [msls.application](../vs140/html-client-api-reference.md#app).  
  
 `bindingPath`: Gets the binding path between the "data" property (the source) and the "value" property (the target). Type: `String`.  
  
 Example:  
  
```javascript  
// Adds a div element each time the value of ValueControl1 content item changes.  
myapp.EditTable1Item.ChangeNotesControl_render = function (element, contentItem) {  
    var valueControlContentItem = contentItem.screen.findContentItem("ValueControl1");  
    contentItem.dataBind(valueControlContentItem.bindingPath, function (newValue) {  
        $(element).append($("<div> Value of control changed at " + msls.relativeDates.now().toString() + "</div>"));  
    });  
};  
```  
  
 `children`: Gets the child content items owned by this content item. For example, the children of a **Tab** would be all the controls shown while the tab is active. Type: Array of `Object`.  
  
 `choiceList`: Gets the list of static choices for the value of this content item, if applicable. Type: Array.  
  
 Example:  
  
```javascript  
myapp.Screen1.created = function (screen) {  
    var myDropDown = screen.findContentItem("Status");  
    var myCustomChoices = new Array({ value: "Active", stringValue: "Active" }, { value: "Resolved", stringValue: "Resolved" });  
  
    myDropDown.choiceList = myCustomChoices;  
    myDropDown.dispatchChange("choiceList");  
    myDropDown.dispatchChange("value");  
};  
```  
  
 `choicesSource`: Gets or sets a visual collection that provides a dynamic set of choices for the value of this content item. Type: [msls.VisualCollection](../vs140/html-client-api-reference.md#visual).  
  
> [!NOTE]
>  Only applies to the **Details Modal Picker** control.  
  
 The default value is `Auto`. At run time, the control dynamically creates a visual collection that contains every item on the server.  `choicesSource` can be updated to a more specific visual collection, like the results of a query.  Note that the control only initializes the visual collection once for performance reasons.  
  
 `commandItems`: Gets the command content items owned by this content item. Type: Array of [msls.ContentItem](../vs140/html-client-api-reference.md#item).  
  
 `controlModel`: Gets the model item describing the control that is visualizing this content item. Type: `Object`.  
  
 `data`: Gets the source data object from which the **details** and **value** properties are bound. Type: `Object`.  
  
 `description`: Gets or sets the description for this content item. Type: `String`.  
  
 `details`: Gets the `Details` property object for the value that this content item represents, using a binding path that is derived from the [bindingPath](../vs140/html-client-api-reference.md#bindingPath) property. Type: `msls.BusinessObject.Details.Property`.  
  
 `displayError`: Gets the display error that occurred for the control, if any. Type: `String`.  
  
 `displayName`: Gets or sets the display name for this content item. Type:  `String`.  
  
 `heightSizingMode`: Gets the height sizing mode for this content item. Type: [msls.HeightSizingMode](../vs140/html-client-api-reference.md#height) (`String`).  
  
 `horizontalAlignment`: Gets the horizontal alignment of this content item. Type: [msls.HorizontalAlignment](../vs140/html-client-api-reference.md#horizontal) (`String`).  
  
 `isEnabled`: Gets a value indicating if the control for this content item should be enabled. Type: `Boolean`.  
  
 `isLoading`: Gets a value indicating if the control for this content item should be shown in the loading state. Type: `Boolean`.  
  
 `isReadOnly`: Gets a value indicating if the control for this content item should be read only. Type: `Boolean`.  
  
 `isVisible`: Gets or sets a value indicating if the control for this content item should be visible. Type: `Boolean`.  
  
 `kind`: Gets the kind of this content item. Type: [msls.ContentItemKind](../vs140/html-client-api-reference.md#kind) (`String`).  
  
 Example:  
  
```javascript  
// Adds description help to each content item  
myapp.AddEditCustomer.columns_postRender = function (element, contentItem) {  
    // Look for content items with type either 'details' (a navigation property)   
    // or 'value' (non-relationship properties)   
    var contentItemTypes = [];  
    contentItemTypes.push(msls.ContentItemKind.details);  
    contentItemTypes.push(msls.ContentItemKind.value);  
    // Find these content items starting from the children of the 'columns' content item   
    var matchingContentItems = findMatchingContentItems(contentItemTypes, contentItem);  
    // Find all LABEL elements that are descendants of the parent element rendering the   
    // 'columns' content item   
    var $matchingElements = $(element).find("label");  
    $.each($matchingElements, function (index) {  
        // Set the LABEL element to float left   
        $(this).css("float", "left");  
        // Create a new A element that will display the '?' link   
        var $help = $("<a href='#'>?</a>");  
        $help.css({ "cursor": "pointer", "display": "block", "float": "right" });  
        var correspondingContentItem = matchingContentItems[index];  
        // Add a click event handler to display the content item description   
        $help.on('click', function (e) {  
            e.preventDefault();  
            contentItem.screen.HelpText = correspondingContentItem.description;  
            contentItem.screen.showPopup('Help');  
        });  
        // Insert the help element as a sibling after the LABEL element   
        $(this).after($help);  
    });  
};   
function findMatchingContentItems(arrayOfTypes, parentContentItem) {  
    var matches = [];  
    // Return an empty array if no children to look at   
    if (parentContentItem.children.length == 0) {  
        return matches;  
    }  
    $.each(parentContentItem.children, function (i, contentItem) {  
        $.each(arrayOfTypes, function (j, type) {  
            if (contentItem.kind == type) {  
                matches.push(contentItem);  
            }  
        });  
        // Check the child's children for matches   
        matches = matches.concat(findMatchingContentItems(arrayOfTypes, contentItem));  
    });  
    return matches;  
};  
```  
  
 `model`: Gets the model item that describes this content item. Type: `Object`.  
  
 `name`:  Gets the name of this content item. Type: `String`.  
  
 `onchange`: Gets or sets a handler for the change event, which is called any time the value of an observable property on this object changes. Type: `Function`.  
  
 `pageKind`: Gets the type of page (`None`, `Popup`, `Tab`) of this content item. Type: [msls.PageKind](../vs140/html-client-api-reference.md#page) (`String`).  
  
 `parent`: Gets the parent content item that owns this content item. Type: [msls.ContentItem](../vs140/html-client-api-reference.md#item).  
  
 `properties`: Gets the set of control-specific properties used to configure the visualization of this content item. Type: `Object`.  
  
 `screen`: Gets the screen that produced this content item. Type: [msls.Screen](../vs140/html-client-api-reference.md#screen).  
  
 `stringValue`: Gets or sets the string representation of the **value** property. It’s preferable to use this property instead of the `value` property when getting a value to be displayed on the screen. Type: `String`.  
  
 `validationResults`: Gets or sets the current set of validation results for this content item. Type: Array of [msls.ValidationResult](../vs140/html-client-api-reference.md#validation).  
  
 Includes any results that were explicitly set into this property, plus any results that were added by automatic validation or by calling the `validate()` method. Note that the validation results will not be displayed until the user modifies the property in the UI or tries to save.  
  
 Example:  
  
```javascript  
screen.findContentItem("OrderDate").validationResults = [new msls.ValidationResult(screen.Order.details.properties.OrderDate, "Invalid date")];  
```  
  
 `value`: Gets or sets the value that this content item represents. Type: `Object`.  
  
 `valueModel`: Gets the model item that describes the value of this content item. Type: `Object`.  
  
 `widthSizingMode`: Gets the width-sizing mode for this content item. Type: [msls.WidthSizingMode](../vs140/html-client-api-reference.md#width) (`String`).  
  
 **Methods**  
  
 `addChangeListener`: Adds a change event listener.  
  
 `addChangeListener(propertyName, listener)`  
  
 Parameter `propertyName`: A property name, or null for the global change event. Type: `String`.  
  
 Parameter `listener`: The function to call when the change event is raised. Type: `Function`.  
  
 Example:  
  
```javascript  
myapp.AddEditCustomer.created = function (screen) {  
function onPropertyChanged() {  
    // Do something.  
}  
screen.Customer.addChangeListener(  
    "Property", onPropertyChanged);  
  
function onEvent() {  
    // Do something.  
}  
screen.Customer.addEventListener(  
    "Event", onEvent);  
  
// Clean up when screen is closed.  
screen.details.rootContentItem  
.handleViewDispose(function () {  
    screen.Customer.removeChangeListener(  
        "Property", onPropertyChanged);  
    screen.Customer.removeEventListener(  
        "Event", onEvent);  
});  
};  
```  
  
 `dataBind`: Binds to a source that is identified by a binding path (for example, `value.unitPrice`).  
  
 `dataBind(bindingPath, callback)`  
  
 Parameter `bindingPath`: A dot-delimited binding path that describes the path to the source. Type: `String`.  
  
 Parameter `callback`: A function that is called when the source changes. Type: `Function`.  
  
 Example:  
  
```javascript  
myapp.ViewCustomer.Details_postRender = function (element, contentItem) {   
    contentItem.dataBind("screen.Customer.Name", function (value) {   
        contentItem.screen.details.displayName = value;   
    });   
};  
```  
  
 `dispatchChange`: Raises a change event for a property.  
  
 `dispatchChange(propertyName)`  
  
 Parameter `propertyName`: A property name. Type: `String`.  
  
 Example:  
  
```javascript  
myapp.ViewIncidents.created = function (screen) {  
   myapp.activeDataWorkspace.Main  
  .Statuses  
  .load()  
  .then(function onComplete(data) {  
      var choice = screen.findContentItem("Status"),  
          values = [];  
      data.results.forEach(function (status){  
          values.push({  
              value: status.Id,  
              stringValue: status.Title  
          });  
      });  
      choice.choiceList = values;  
      choice.dispatchChange("choiceList");  
  }, function onError(error) {  
      msls.showMessageBox(error, {  
          title: "Error loading Statuses from the backend"  
      });  
  });  
}  
```  
  
 `findItem`: Recursively searches for a content item starting from this content item.  
  
 `findItem(contentItemName)`  
  
 Parameter `contentItemName`: The unique name of a content item. Type: `String`.  
  
 Returns [msls.ContentItem](../vs140/html-client-api-reference.md#item): The content item with the specified name, if found; otherwise, a false value.  
  
 `handleViewDispose`: Sets a handler for the view dispose event.  
  
 `handleViewDispose(handler)`  
  
 Parameter: `handler`: A function that is called when the view for this content item is disposed. Type: `Function`.  
  
 Example:  
  
```javascript  
myapp.AddEditCustomer.created = function (screen) {  
function onPropertyChanged() {  
    // Do something.  
}  
screen.Customer.addChangeListener(  
    "Property", onPropertyChanged);  
  
function onEvent() {  
    // Do something.  
}  
screen.Customer.addEventListener(  
    "Event", onEvent);  
  
// Clean up when screen is closed.  
screen.details.rootContentItem  
.handleViewDispose(function () {  
    screen.Customer.removeChangeListener(  
        "Property", onPropertyChanged);  
    screen.Customer.removeEventListener(  
        "Event", onEvent);  
});  
};  
```  
  
 `hasValidationErrors`: Indicates if this content item currently has validation errors.  
  
 `hasValidationErrors(recursive)`  
  
 Parameter `recursive`: Indicates if child content items should also be checked. Type: `Boolean`.  
  
 Returns `Boolean`: true if there are validation errors; otherwise, false.  
  
 Example:  
  
```javascript  
if (screen.findContentItem("name").hasValidationErrors()) {  
        screen.findContentItem("name").validationResults = [];  
    }  
```  
  
 `removeChangeListener`: Removes a change event listener.  
  
 `removeChangeListener(propertyName, listener)`  
  
 Parameter `propertyName`: A property name, or null for the global change event. Type: `String`.  
  
 Parameter `listener`: The event listener that should be removed. Type: `Function`.  
  
 Example:  
  
```javascript  
myapp.AddEditCustomer.created = function (screen) {  
function onPropertyChanged() {  
    // Do something.  
}  
screen.Customer.addChangeListener(  
    "Property", onPropertyChanged);  
  
function onEvent() {  
    // Do something.  
}  
screen.Customer.addEventListener(  
    "Event", onEvent);  
  
// Clean up when screen is closed.  
screen.details.rootContentItem  
.handleViewDispose(function () {  
    screen.Customer.removeChangeListener(  
        "Property", onPropertyChanged);  
    screen.Customer.removeEventListener(  
        "Event", onEvent);  
});  
};  
```  
  
 `validate`: Runs defined validation rules on the value property and updates the value of the **validationResults** property.  
  
 `validate(recursive)`  
  
 Optional parameter `recursive`: Indicates if child content items should also be validated. If true, the **validationResults** property on child content items are updated. Type: `Boolean`.  
  
##  \<a name="kind"></a> msls.ContentItemKind  
 `msls.ContentItemKind`  
  
 Specifies the kind of a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|`collection`|Specifies a content item that binds to a visual collection.|  
|`command`|Specifies a content item that binds to a command that invokes a method.|  
|`details`|Specifies a content item that binds to an object such as an entity.|  
|`group`|Specifies a content item that contains other content items.|  
|`popup`|Specifies the root content item of a popup on a screen.|  
|`screen`|Specifies the root content item of a screen.|  
|`tab`|Specifies the root content item of a tab on a screen.|  
|`value`|Specifies a content item that binds to a value such as a number, date or string.|  
  
##  \<a name="service"></a> msls.DataService  
 `msls.DataService(dataWorkspace)`  
  
 Represents a data service.  
  
 Optional parameter `dataWorkspace`: The data workspace that owns this data service. Type: [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace).  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`dataService`|Gets the data service that owns this details object.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|`dataWorkspace`|Gets the data workspace that manages the data service, if any.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|`details`|Represents the details for a data service.|`msls.DataService.Details`|  
|`hasChanges`|Gets a value that indicates whether the data service has changes (that is, whether there are entities pending addition, modification or deletion).|`Boolean`|  
|`oncontentchange`|Gets or sets a handler for the `contentchange` event, which is called any time any entity owned by the data service changes.|`Function`|  
|`owner`|Gets the data service that owns this details object.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|`properties`|Gets the set of property objects for the data service.|`msls.DataService.Details.PropertySet`|  
  
##  \<a name="query"></a> msls.DataServiceQuery  
 `msls.DataServiceQuery(source, rootUri, queryParameters)`  
  
 Represents a data service query.  
  
 Parameter `source`: A source queryable object.  
  
 Optional parameter `rootUri`: The root request URI if this is a root data service query (for example, a collection navigation query). Type: **String**.  
  
 Optional parameter `queryParameters`: The query parameters, if available (for example, a screen query based a query operation with parameters). Type: `String`.  
  
##  \<a name="workspace"></a> msls.DataWorkspace  
 `msls.DataWorkspace()`  
  
 Represents a data workspace.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`dataWorkspace`|Gets the data workspace that owns this details object.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|`details`|Represents the details for a data workspace.|`msls.DataWorkspace.Details`|  
|`hasChanges`|Gets a value that indicates whether the data workspace has changes (that is, whether there are entities pending addition, modification or deletion).|`Boolean`|  
|`hasNestedChangeSets`|Gets a value that indicates whether the data workspace has any nested change sets.|`Boolean`|  
|`NestedChangeSet(owner)`|Represents a nested change set.||  
|`oncontentchange`|Gets or sets a handler for the `contentchange` event, which is called any time any entity owned by any data service owned by this data workspace changes.|`Function`|  
|`owner`|Gets the data workspace that owns this details object.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|`properties`|Gets the set of property objects for the data workspace.|`msls.DataWorkspace.Details.PropertySet`|  
  
##  \<a name="entity"></a> msls.Entity  
 `msls.Entity(entitySet)`  
  
 Represents an entity.  
  
 Optional parameter `entitySet`: An entity set that should contain this entity. Type: [msls.EntitySet](../vs140/html-client-api-reference.md#set).  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`details`|Represents the details for an entity.|`msls.Entity.Details`|  
|`entity`|Gets the entity that owns this details object.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|`entitySet`|Gets the entity set that contains the entity.|[msls.EntitySet](../vs140/html-client-api-reference.md#set)|  
|`entityState`|Gets the state (from [msls.EntityState](../vs140/html-client-api-reference.md#state)) of the entity.|`String`|  
|`hasEdits`|Gets a value that indicates whether the entity has edits (that is, if it was added and has been edited, or it is modified or deleted).|`Boolean`|  
|`owner`|Gets the entity that owns this details object.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|`Properties`|Gets the set of property objects for the entity.|`msls.Entity.Details.PropertySet`|  
  
##  \<a name="collection"></a> msls.EntityCollection  
 `msls.EntityCollection(details, data)`  
  
 Represents a local collection of entities.  
  
 Parameter `details`: The details object for the entity that owns this entity collection. Type: `msls.Entity.Details`.  
  
 Parameter `data`: An object that provides property data. Type: `Object`.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`oncollectionchange`|Gets or sets a handler for the collection change event.|`Function`|  
  
##  \<a name="set"></a> msls.EntitySet  
 `msls.EntitySet(dataService, entry)`  
  
 Represents an entity set.  
  
 Parameter `dataService`: The data service that owns this entity set. Type: [msls.DataService](../vs140/html-client-api-reference.md#service).  
  
 Parameter `entry`: An entity set property entry.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`canDelete`|Gets a value that indicates whether entities in this entity set can be deleted.|`Boolean`|  
|`canInsert`|Gets a value that indicates whether entities can be added to this entity set.|`Boolean`|  
|`canUpdate`|Gets a value that indicates whether entities in this entity set can be modified.|`Boolean`|  
|`dataService`|Gets the data service that owns this entity set.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|`name`|Gets the name of this entity set.|`String`|  
  
##  \<a name="state"></a> msls.EntityState  
 `msls.EntityState`  
  
 Specifies the state of an entity.  
  
|Value|Description|  
|-----------|-----------------|  
|`added`|The entity is added.|  
|`deleted`|The entity is marked as deleted.|  
|`discarded`|The entity is discarded.|  
|`modified`|The entity is modified.|  
|`unchanged`|The entity is unchanged.|  
  
##  \<a name="height"></a> msls.HeightSizingMode  
 `msls.HeightSizingMode`  
  
 Specifies how the height of a content item is calculated.  
  
|Value|Description|  
|-----------|-----------------|  
|`FitToContent`|Specifies that the content item height is based on the height of its content.|  
|`FixedSize`|Specifies that the content item height is fixed.|  
|`StretchToContainer`|Specifies that the content item height is based on the available height provided by its parent content item.|  
  
##  \<a name="horizontal"></a> msls.HorizontalAlignment  
 `msls.HorizontalAlignment`  
  
 Specifies the horizontal alignment of a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|`Left`|Specifies that the content item is left-aligned.|  
|`Right`|Specifies that the content item is right-aligned.|  
  
##  \<a name="merge"></a> msls.MergeOption  
 `msls.MergeOption`  
  
 Specifies how entities that are being loaded into the data workspace are merged with entities that are already in the data workspace.  
  
|Value|Description|  
|-----------|-----------------|  
|`appendOnly`|Entities that do not exist in the data workspace are added to the data workspace. If an entity is already in the data workspace, the current and original values of the entity's properties are not overwritten with data source values. This is the default merge option.|  
|`unchangedOnly`|Entities that do not exist in the data workspace are added to the data workspace. If an entity is already in the data workspace and its entity state is unchanged, the current and original values of the entity's properties are overwritten with data source values.|  
  
##  \<a name="buttons"></a> msls.MessageBoxButtons  
 `msls.MessageBoxButtons`  
  
 Specifies the buttons to show in a message box.  
  
|Value|Description|  
|-----------|-----------------|  
|`ok`|Specifies the **OK** button.|  
|`okCancel`|Specifies the **OK** and **Cancel** buttons.|  
|`yesNo`|Specifies the **Yes** and **No** buttons.|  
|`yesNoCancel`|Specifies the **Yes**, **No**, and **Cancel** buttons.|  
  
##  \<a name="result"></a> msls.MessageBoxResult  
 `msls.MessageBoxResult`  
  
 Specifies the button in a message box that was chosen.  
  
|Value|Description|  
|-----------|-----------------|  
|`cancel`|Specifies that the **Cancel** button was invoked.|  
|`no`|Specifies that the **No** button was invoked.|  
|`ok`|Specifies that the **OK** button was invoked.|  
|`yes`|Specifies that the **Yes** button was invoked.|  
  
##  \<a name="back"></a> msls.NavigateBackAction  
 `msls.NavigateBackAction`  
  
 Specifies the action that was taken when navigating back from a screen.  
  
|Value|Description|  
|-----------|-----------------|  
|`cancel`|Specifies that changes on the previous screen were canceled.|  
|`commit`|Specifies that changes on the previous screen were committed to the data source.|  
  
##  \<a name="object"></a> msls.ObjectWithDetails  
 `msls.ObjectWithDetails`  
  
 Represents an object that contains a `details` object.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`details`|Represents the details for an object with details.|**msls.ObjectWithDetails.Details**|  
|`onchange`|Gets or sets a handler for the change event, which is called any time the value of an observable property on this object changes.|`Function`|  
|`owner`|Represents the object that owns this details object.|[msls.ObjectWithDetails](../vs140/html-client-api-reference.md#object)|  
|`properties`|Gets the set of property objects for the owner's properties.|`msls.ObjectWithDetails.Details.PropertySet`|  
  
##  \<a name="page"></a> msls.PageKind  
 `msls.PageKind`  
  
 Specifies the kind of page represented by a content item.  
  
|Value|Description|  
|-----------|-----------------|  
|`None`|Specifies that the content item does not represent a page.|  
|`Popup`|Specifies that the content item represents a popup that is shown using a nested boundary option.|  
|`Tab`|Specifies that the content item represents a tab that appears in the screen tabs bar.|  
  
##  \<a name="screen"></a> msls.Screen  
 `Screen(dataWorkspace, modelId, screenParameters)`  
  
 Represents a screen.  
  
 Parameter `dataWorkspace`: The data workspace associated with the screen. Type: [msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace).  
  
 Parameter `modelId`: The identifier of the model item that defines this screen. Type: `String`.  
  
 Optional parameter `screenParameters`: An object containing parameters to the screen. Type: `Array`.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`dataWorkspace`|Gets the data workspace that provides the screen's data.|[msls.DataWorkspace](../vs140/html-client-api-reference.md#workspace)|  
|`description`|Gets or sets the description for the screen.|`String`|  
|`details`|Represents the details for a screen.|`msls.Screen.Details`|  
|`displayName`|Gets or sets the display name for the screen.|`String`|  
|`owner`|Gets the screen that owns this details object.|`msls.Screen`|  
|`pages`|Gets an array of the root content items for the screen's tabs and popups.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
|`properties`|Gets the set of property objects for the screen.|`msls.Screen.Details.PropertySet`|  
|`rootContentItem`|Gets the root content item for the screen.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
|`saveChangesTo`|Gets an array of the editable data services for the screen.|[msls.DataService](../vs140/html-client-api-reference.md#service)|  
|`screen`|Gets the screen that owns this details object.|`msls.Screen`|  
|`serverErrors`|Gets the server validation errors that occurred when the screen was last saved.|[msls.ValidationResult](../vs140/html-client-api-reference.md#validation)|  
|`startPage`|Gets the root content item for the screen's start page.|[msls.ContentItem](../vs140/html-client-api-reference.md#item)|  
  
##  \<a name="sequence"></a> msls.Sequence  
 `msls.Sequence()`  
  
 Represents a sequence.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`Array`|Gets an array that represents this sequence.|`Object`|  
  
##  \<a name="transition"></a> msls.TransitionAnimationLevel  
 `msls.TransitionAnimationLevel`  
  
 Specifies the level of animation that occurs during transitions.  
  
|Value|Description|  
|-----------|-----------------|  
|`Full`|Use full-transition animations.|  
|`Simple`|Use simpler transition animations that are less processor or power intensive.|  
  
##  \<a name="validation"></a> msls.ValidationResult  
 `msls.ValidationResult(property, message)`  
  
 Represents a validation result.  
  
 Parameter `property`: A property to associate with the validation result. Type: `msls.BusinessObject.Details.Property`.  
  
 Parameter `message`: A message that describes the validation error. Type: `String`.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`message`|Gets a message that describes the validation error.|`String`|  
|`property`|Gets the property on which the validation error occurred.|`msls.BusinessObject.Details.Property`|  
  
##  \<a name="visual"></a> msls.VisualCollection  
 `VisualCollection(screenDetails, loader)`  
  
 Represents a collection of data that is shown by a screen.  
  
 Parameter `screenDetails`: The screen details object that owns the screen collection property whose value is this collection. Type: `msls.Screen.Details`.  
  
 Parameter `loader`: An object that is used to load data into the collection.  
  
 **Members**  
  
|Member|Description|Type|  
|------------|-----------------|----------|  
|`canLoadMore`|Gets a value that indicates whether this collection is able to load more pages of data.|`Boolean`|  
|`count`|Gets the number of items that are currently in this collection.|`Integer`|  
|`data`|Gets the items that are currently in this collection.|`Array`|  
|`isLoaded`|Gets a value that indicates whether this collection has loaded one or more pages of data.|`Boolean`|  
|`loadError`|Gets the last load error that occurred, or returns null if no error occurred.|`String`|  
|`screen`|Gets the screen that owns this collection.|[msls.Screen](../vs140/html-client-api-reference.md#screen)|  
|`selectedItem`|Gets or sets the currently selected item.|[msls.Entity](../vs140/html-client-api-reference.md#entity)|  
|`state`|Gets the current state (from `msls.VisualCollection.State`) of this collection.|`String`|  
  
 `VisualCollection.State` values:  
  
|Value|Description|  
|-----------|-----------------|  
|`idle`|Specifies that the visual collection is not currently loading data.|  
|`loading`|Specifies that the visual collection is currently loading data.|  
|`loadingMore`|Specifies that the visual collection is currently loading more data.|  
  
##  \<a name="width"></a> msls.WidthSizingMode  
 `msls.WidthSizingMode`  
  
 Specifies how the width of a content item is calculated.  
  
|Value|Description|  
|-----------|-----------------|  
|`FitToContent`|Specifies that the content item width is based on the width of its content.|  
|`FixedSize`|Specifies that the content item width is fixed.|  
|`StretchToContainer`|Specifies that the content item width is based on the available width provided by its parent content item.|  
  
## See Also  
 [How to: Handle Screen Events in a Mobile Client for a LightSwitch App](../vs140/how-to--handle-screen-events-in-a-mobile-client-for-a-lightswitch-app.md)   
 [How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md)   
 [HTML Client Screens for LightSwitch Apps](../vs140/html-client-screens-for-lightswitch-apps.md)