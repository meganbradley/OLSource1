---
title: "Customizing Which Objects are Available in My (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My namespace, customizing"
  - "My namespace"
ms.assetid: 4e8279c2-ed5b-4681-8903-8a6671874000
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Customizing Which Objects are Available in My (Visual Basic)
This topic describes how you can control which `My` objects are enabled by setting your project's `_MYTYPE` conditional-compilation constant. The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Integrated Development Environment (IDE) keeps the `_MYTYPE` conditional-compilation constant for a project in sync with the project's type.  
  
## Predefined _MYTYPE Values  
 You must use the `/define` compiler option to set the `_MYTYPE` conditional-compilation constant. When specifying your own value for the `_MYTYPE` constant, you must enclose the string value in backslash/quotation mark (\\") sequences. For example, you could use:  
  
```  
/define:_MYTYPE=\"WindowsForms\"  
```  
  
 This table shows what the `_MYTYPE` conditional-compilation constant is set to for several project types.  
  
|Project type|_MYTYPE value|  
|------------------|--------------------|  
|Class Library|"Windows"|  
|Console Application|"Console"|  
|Web|"Web"|  
|Web Control Library|"WebControl"|  
|Windows Application|"WindowsForms"|  
|Windows Application, when starting with custom `Sub Main`|"WindowsFormsWithCustomSubMain"|  
|Windows Control Library|"Windows"|  
|Windows Service|"Console"|  
|Empty|"Empty"|  
  
> [!NOTE]
>  All conditional-compilation string comparisons are case-sensitive, regardless of how the `Option Compare` statement is set.  
  
## Dependent _MY Compilation Constants  
 The `_MYTYPE` conditional-compilation constant, in turn, controls the values of several other `_MY` compilation constants:  
  
|_MYTYPE|_MYAPPLICATIONTYPE|_MYCOMPUTERTYPE|_MYFORMS|_MYUSERTYPE|_MYWEBSERVICES|  
|--------------|-------------------------|----------------------|---------------|------------------|---------------------|  
|"Console"|"Console"|"Windows"|Undefined|"Windows"|TRUE|  
|"Custom"|Undefined|Undefined|Undefined|Undefined|Undefined|  
|"Empty"|Undefined|Undefined|Undefined|Undefined|Undefined|  
|"Web"|Undefined|"Web"|FALSE|"Web"|FALSE|  
|"WebControl"|Undefined|"Web"|FALSE|"Web"|TRUE|  
|"Windows" or ""|"Windows"|"Windows"|Undefined|"Windows"|TRUE|  
|"WindowsForms"|"WindowsForms"|"Windows"|TRUE|"Windows"|TRUE|  
|"WindowsFormsWithCustomSubMain"|"Console"|"Windows"|TRUE|"Windows"|TRUE|  
  
 By default, undefined conditional-compilation constants resolve to `FALSE`. You can specify values for the undefined constants when compiling your project to override the default behavior.  
  
> [!NOTE]
>  When `_MYTYPE` is set to "Custom", the project contains the `My` namespace, but it contains no objects. However, setting `_MYTYPE` to "Empty" prevents the compiler from adding the `My` namespace and its objects.  
  
 This table describes the effects of the predefined values of the `_MY` compilation constants.  
  
|Constant|Meaning|  
|--------------|-------------|  
|`_MYAPPLICATIONTYPE`|Enables `My.Application`, if the constant is "Console," Windows," or "WindowsForms":<br /><br /> -   The "Console" version derives from <xref:Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase*>. and has fewer members than the "Windows" version.<br />-   The "Windows" version derives from <xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase*>.and has fewer members than the "WindowsForms" version.<br />-   The "WindowsForms" version of `My.Application` derives from <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase*>. If the `TARGET` constant is defined to be "winexe", then the class includes a `Sub Main` method.|  
|`_MYCOMPUTERTYPE`|Enables `My.Computer`, if the constant is "Web" or "Windows":<br /><br /> -   The "Web" version derives from <xref:Microsoft.VisualBasic.Devices.ServerComputer*>, and has fewer members than the "Windows" version.<br />-   The "Windows" version of `My.Computer` derives from <xref:Microsoft.VisualBasic.Devices.Computer*>.|  
|`_MYFORMS`|Enables `My.Forms`, if the constant is `TRUE`.|  
|`_MYUSERTYPE`|Enables `My.User`, if the constant is "Web" or "Windows":<br /><br /> -   The "Web" version of `My.User` is associated with the user identity of the current HTTP request.<br />-   The "Windows" version of `My.User` is associated with the thread's current principal.|  
|`_MYWEBSERVICES`|Enables `My.WebServices`, if the constant is `TRUE`.|  
|`_MYTYPE`|Enables `My.Log`, `My.Request`, and `My.Response`, if the constant is "Web".|  
  
## See Also  
 <xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase*>   
 <xref:Microsoft.VisualBasic.Devices.Computer*>   
 <xref:Microsoft.VisualBasic.Logging.Log*>   
 <xref:Microsoft.VisualBasic.ApplicationServices.User*>   
 [How My Depends on Project Type](../vs140/how-my-depends-on-project-type--visual-basic-.md)   
 [Conditional Compilation Overview](../vs140/conditional-compilation-in-visual-basic.md)   
 [/define (Visual Basic)](../vs140/-define--visual-basic-.md)   
 [My.Forms Object](../vs140/my.forms-object.md)   
 [My.Request Object](../vs140/my.request-object.md)   
 [My.Response Object](../vs140/my.response-object.md)   
 [My.WebServices Object](../vs140/my.webservices-object.md)