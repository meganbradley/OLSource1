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
This topic describes how you can control which <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects are enabled by setting your project's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> conditional-compilation constant. The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Integrated Development Environment (IDE) keeps the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> conditional-compilation constant for a project in sync with the project's type.  
  
## Predefined _MYTYPE Values  
 You must use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> compiler option to set the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> conditional-compilation constant. When specifying your own value for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> constant, you must enclose the string value in backslash/quotation mark (\\") sequences. For example, you could use:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This table shows what the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> conditional-compilation constant is set to for several project types.  
  
|Project type|_MYTYPE value|  
|------------------|--------------------|  
|Class Library|"Windows"|  
|Console Application|"Console"|  
|Web|"Web"|  
|Web Control Library|"WebControl"|  
|Windows Application|"WindowsForms"|  
|Windows Application, when starting with custom <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|"WindowsFormsWithCustomSubMain"|  
|Windows Control Library|"Windows"|  
|Windows Service|"Console"|  
|Empty|"Empty"|  
  
> [!NOTE]
>  All conditional-compilation string comparisons are case-sensitive, regardless of how the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement is set.  
  
## Dependent _MY Compilation Constants  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> conditional-compilation constant, in turn, controls the values of several other <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> compilation constants:  
  
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
  
 By default, undefined conditional-compilation constants resolve to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You can specify values for the undefined constants when compiling your project to override the default behavior.  
  
> [!NOTE]
>  When <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to "Custom", the project contains the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> namespace, but it contains no objects. However, setting <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to "Empty" prevents the compiler from adding the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> namespace and its objects.  
  
 This table describes the effects of the predefined values of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> compilation constants.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, if the constant is "Console," Windows," or "WindowsForms":\<br />\<br /> -   The "Console" version derives from \<xref:Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase*>. and has fewer members than the "Windows" version.\<br />-   The "Windows" version derives from \<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase*>.and has fewer members than the "WindowsForms" version.\<br />-   The "WindowsForms" version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> derives from \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase*>. If the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> constant is defined to be "winexe", then the class includes a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, if the constant is "Web" or "Windows":\<br />\<br /> -   The "Web" version derives from \<xref:Microsoft.VisualBasic.Devices.ServerComputer*>, and has fewer members than the "Windows" version.\<br />-   The "Windows" version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> derives from \<xref:Microsoft.VisualBasic.Devices.Computer*>.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, if the constant is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, if the constant is "Web" or "Windows":\<br />\<br /> -   The "Web" version of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is associated with the user identity of the current HTTP request.\<br />-   The "Windows" version of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is associated with the thread's current principal.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, if the constant is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Enables <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, if the constant is "Web".|  
  
## See Also  
 \<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase*>   
 \<xref:Microsoft.VisualBasic.Devices.Computer*>   
 \<xref:Microsoft.VisualBasic.Logging.Log*>   
 \<xref:Microsoft.VisualBasic.ApplicationServices.User*>   
 [How My Depends on Project Type](../vs140/how-my-depends-on-project-type--visual-basic-.md)   
 [Conditional Compilation Overview](../vs140/conditional-compilation-in-visual-basic.md)   
 [/define (Visual Basic)](../vs140/-define--visual-basic-.md)   
 [My.Forms Object](../vs140/my.forms-object.md)   
 [My.Request Object](../vs140/my.request-object.md)   
 [My.Response Object](../vs140/my.response-object.md)   
 [My.WebServices Object](../vs140/my.webservices-object.md)