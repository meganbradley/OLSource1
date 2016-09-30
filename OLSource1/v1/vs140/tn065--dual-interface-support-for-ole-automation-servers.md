---
title: "TN065: Dual-Interface Support for OLE Automation Servers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dual interfaces, OLE Automation"
  - "TN065"
  - "ACDUAL sample [MFC]"
  - "Automation servers, dual-interface support"
ms.assetid: b5c8ed09-2f7f-483c-80fc-2a47ad896063
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN065: Dual-Interface Support for OLE Automation Servers
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note discusses how to add dual-interface support to an MFC-based OLE Automation server application. The [ACDUAL](../vs140/visual-c---samples.md) sample illustrates dual-interface support, and the example code in this note is taken from ACDUAL. The macros described in this note, such as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, are part of the ACDUAL sample and can be found in MFCDUAL.H.  
  
## Dual Interfaces  
 Although OLE Automation allows you to implement an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interface, a VTBL interface, or a dual interface (which encompasses both), Microsoft strongly recommends that you implement dual interfaces for all exposed OLE Automation objects. Dual interfaces have significant advantages over <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>-only or VTBL-only interfaces:  
  
-   Binding can take place at compile time through the VTBL interface, or at run time through <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
-   OLE Automation controllers that can use the VTBL interface may benefit from improved performance.  
  
-   Existing OLE Automation controllers that use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> interface will continue to work.  
  
-   The VTBL interface is easier to call from C++.  
  
-   Dual interfaces are required for compatibility with Visual Basic object support features.  
  
## Adding Dual-Interface Support to a CCmdTarget-Based Class  
 A dual interface is really just a custom interface derived from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The most straightforward way to implement dual-interface support in a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>-based class is to first implement the normal dispatch interface on your class using MFC and ClassWizard, then add the custom interface later. For the most part, your custom interface implementation will simply delegate back to the MFC <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> implementation.  
  
 First, modify the ODL file for your server to define dual interfaces for your objects. To define a dual interface, you must use an interface statement, instead of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement that the Visual C++ wizards generate. Rather than removing the existing <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement, add a new interface statement. By retaining the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> form, you can continue to use ClassWizard to add properties and methods to your object, but you must add the equivalent properties and methods to your interface statement.  
  
 An interface statement for a dual interface must have the **OLEAUTOMATION** and **DUAL** attributes, and the interface must be derived from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. You can use the [GUIDGEN](../vs140/visual-c---samples.md) sample to create a **IID** for the dual interface:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Once you have the interface statement in place, start adding entries for the methods and properties. For dual interfaces, you need to rearrange the parameter lists so that your methods and property accessor functions in the dual interface return an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and pass their return values as parameters with the attributes <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Remember that for properties, you will need to add both a read (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) and write (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>) access function with the same id. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 After your methods and properties are defined, you need to add a reference to the interface statement in your coclass statement. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Once your ODL file has been updated, use MFC's interface map mechanism to define an implementation class for the dual interface in your object class and make the corresponding entries in MFC's <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> mechanism. You need one entry in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block for each entry in the interface statement of the ODL, plus the entries for a dispatch interface. Each ODL entry with the **propput** attribute needs a function named <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Each entry with the **propget** attribute needs a function named <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 To define an implementation class for your dual interface, add a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> block to your object class definition. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To connect the dual interface to MFC's [QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms687230) mechanism, add an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> entry to the interface map:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Next, you need to fill in the implementation of the interface. For the most part, you will be able to delegate to the existing MFC <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> implementation. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For your object's methods and property accessor functions, you need to fill in the implementation. Your method and property functions can generally delegate back to the methods generated using ClassWizard. However, if you set up properties to access variables directly, you need to write the code to get/put the value into the variable. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Passing Dual-Interface Pointers  
 Passing your dual-interface pointer isn't straightforward, especially if you need to call <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> only works on MFC's <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> pointers. One way to work around this is to query for the original <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> pointer set up by MFC and pass that pointer to functions that need it. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Before passing a pointer back through the dual-interface method, you might need to convert it from the MFC <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> pointer to your dual-interface pointer. For example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Registering the Application's Type Library  
 AppWizard does not generate code to register an OLE Automation server application's type library with the system. While there are other ways to register the type library, it is convenient to have the application register the type library when it is updating its OLE type information, that is, whenever the application is run stand-alone.  
  
 To register the application's type library whenever the application is run stand alone:  
  
-   Include AFXCTL.H in your standard includes header file, STDAFX.H, to access the definition of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function.  
  
-   In your application's <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> function, locate the call to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. Following this call, add a call to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, specifying the **LIBID** corresponding to your type library, along with the name of your type library:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Modifying Project Build Settings to Accommodate Type Library Changes  
 To modify a project's build settings so that a header file containing **UUID** definitions is generated by MkTypLib whenever the type library is rebuilt:  
  
1.  On the **Build** menu, click **Settings**, and then select the ODL file from the file list for each configuration.  
  
2.  Click the **OLE Types** tab and specify a filename in the **Output header** filename field. Use a filename that is not already used by your project, because MkTypLib will overwrite any existing file. Click **OK** to close the **Build Settings** dialog box.  
  
 To add the **UUID** definitions from the MkTypLib-generated header file to your project:  
  
1.  Include the MkTypLib-generated header file in your standard includes header file, STDAFX.H.  
  
2.  Create a new file, INITIIDS.CPP, and add it to your project. In this file, include your MkTypLib-generated header file after including OLE2.H and INITGUID.H:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
3.  On the **Build** menu, click **Settings**, and then select INITIIDS.CPP from the file list for each configuration.  
  
4.  Click the **C++** tab, click category **Precompiled Headers**, and select the **Not using precompiled headers** radio button. Click OK to close the **Build Settings** dialog box.  
  
## Specifying the Correct Object Class Name in the Type Library  
 The wizards shipped with Visual C++ incorrectly use the implementation class name to specify the coclass in the server's ODL file for OLE-creatable classes. While this will work, the implementation class name is probably not the class name you want users of your object to use. To specify the correct name, open the ODL file, locate each coclass statement, and replace the implementation class name with the correct external name.  
  
 Note that when the coclass statement is changed, the variable names of **CLSID**s in the MkTypLib-generated header file will change accordingly. You will need to update your code to use the new variable names.  
  
## Handling Exceptions and the Automation Error Interfaces  
 Your automation object's methods and property accessor functions may throw exceptions. If so, you should handle them in your dual-interface implementation and pass information about the exception back to the controller through the OLE Automation error-handling interface, **IErrorInfo**. This interface provides for detailed, contextual error information through both <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and VTBL interfaces. To indicate that an error handler is available, you should implement the **ISupportErrorInfo** interface.  
  
 To illustrate the error-handling mechanism, assume that the ClassWizard-generated functions used to implement the standard dispatch support throw exceptions. MFC's implementation of **IDispatch::Invoke** typically catches these exceptions and converts them into an EXCEPTINFO structure that is returned through the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> call. However, when VTBL interface is used, you are responsible for catching the exceptions yourself. As an example of protecting your dual-interface methods:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> takes care of returning the correct error code when an exception occurs. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> converts an MFC exception into OLE Automation error-handling information using the **ICreateErrorInfo** interface. (An example <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> macro is in the file MFCDUAL.H in the [ACDUAL](../vs140/visual-c---samples.md) sample. The function it calls to handle exceptions, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, is in the file MFCDUAL.CPP.) <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> determines the error code to return based on the type of exception that occurred:  
  
-   [COleDispatchException](../vs140/coledispatchexception-class.md) – In this case, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is constructed using the following code:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     This creates an <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> specific to the interface that caused the exception. The error code is offset by 0x200 to avoid any conflicts with system-defined <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>s for standard OLE interfaces.  
  
-   [CMemoryException](../vs140/cmemoryexception-class.md) – In this case, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is returned.  
  
-   Any other exception – In this case, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is returned.  
  
 To indicate that the OLE Automation error handler is used, you should also implement the **ISupportErrorInfo** interface.  
  
 First, add code to your automation class definition to show it supports **ISupportErrorInfo**.  
  
 Second, add code to your automation class's interface map to associate the **ISupportErrorInfo** implementation class with MFC's <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> mechanism. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement matches the class defined for **ISupportErrorInfo**.  
  
 Finally, implement the class defined to support **ISupportErrorInfo**.  
  
 (The [ACDUAL](../vs140/visual-c---samples.md) sample contains three macros to help do these three steps, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, all contained in MFCDUAL.H.)  
  
 The following example implements a class defined to support **ISupportErrorInfo**. <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is the name of your automation class and <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is the **IID** for the interface that is the source of errors reported through the OLE Automation error object:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)