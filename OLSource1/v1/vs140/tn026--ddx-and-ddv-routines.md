---
title: "TN026: DDX and DDV Routines"
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
  - "DDX"
  - "DDV"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX (dialog data exchange), procedures"
  - "TN026"
  - "DDV (dialog data validation), procedures"
ms.assetid: c2eba87a-4b47-4083-b28b-e2fa77dfb4c4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN026: DDX and DDV Routines
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note describes the dialog data exchange (DDX) and dialog data validation (DDV) architecture. It also describes how you write a DDX_ or DDV_ procedure and how you can extend ClassWizard to use your routines.  
  
## Overview of Dialog Data Exchange  
 All dialog data functions are done with C++ code. There are no special resources or magic macros. The heart of the mechanism is a virtual function that is overridden in every dialog class that does dialog data exchange and validation. It is always found in this form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The special format AFX comments allow ClassWizard to locate and edit the code within this function. Code that is not compatible with ClassWizard should be placed outside of the special format comments.  
  
 In the above example, \<data_exchange_function_call> is in the form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 and \<data_validation_function_call> is optional and is in the form:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 More than one DDX_/DDV_ pair may be included in each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function.  
  
 See 'afxdd_.h' for a list of all the dialog data exchange routines and dialog data validation routines provided with MFC.  
  
 Dialog data is just that: member data in the **CMyDialog** class. It is not stored in a struct or anything similar.  
  
## Notes  
 Although we call this "dialog data," all features are available in any class derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and are not limited to just dialogs.  
  
 Initial values of data are set in the standard C++ constructor, usually in a block with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> comments.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the operation that does the initialization and error handling around the call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 You can call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> at any time to perform data exchange and validation. By default <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>(TRUE) is called in the default <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> handler and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>(FALSE) is called in the default <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The DDV_ routine should immediately follow the DDX_ routine for that *field*.  
  
## How Does It Work?  
 You do not need to understand the following in order to use dialog data. However, understanding how this works behind the scenes will help you write your own exchange or validation procedure.  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member function is much like the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function - it is responsible for getting or setting data to/from an external form (in this case controls in a dialog) from/to member data in the class. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter is the context for doing data exchange and is similar to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> (a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object) has a direction flag much like <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> has a direction flag:  
  
-   If **!m_bSaveAndValidate**, then load the data state into the controls.  
  
-   If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, then set the data state from the controls.  
  
 Validation only occurs when <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is set. The value of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is determined by the BOOL parameter to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 There are three other interesting <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> members:  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>: The window (usually a dialog) that contains the controls. This is to prevent callers of the DDX_ and DDV_ global functions from having to pass 'this' to every DDX/DDV routine.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>: Prepares a dialog control for data exchange. Stores that control's handle for setting the focus if a validation fails. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is used for nonedit controls and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is used for edit controls.  
  
-   **Fail**: Called after bringing up a message box alerting the user to the input error. This routine will restore the focus to the last control (the last call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>) and throw an exception. This member function may be called from both DDX_ and DDV_ routines.  
  
## User Extensions  
 There are several ways to extend the default DDX/DDV mechanism. You can:  
  
-   Add new data types.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Add new exchange procedures (DDX_???).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Add new validation procedures (DDV_???).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   Pass arbitrary expressions to the validation procedures.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  Such arbitrary expressions cannot be edited by ClassWizard and therefore should be moved outside of the special format comments (//{{AFX_DATA_MAP(CMyClass)).  
  
 Have the **DoDialogExchange** member function include conditionals or any other valid C++ statements with intermixed exchange and validation function calls.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
> [!NOTE]
>  As shown above, such code cannot be edited by ClassWizard and should be used only outside of the special format comments.  
  
## ClassWizard Support  
 ClassWizard supports a subset of DDX/DDV customizations by allowing you to integrate your own DDX_ and DDV_ routines into the ClassWizard user interface. Doing this is only cost beneficial if you plan to reuse particular DDX and DDV routines in a project or in many projects.  
  
 To do this, special entries are made in DDX.CLW (previous versions of Visual C++ stored this information in APSTUDIO.INI) or in your project's .CLW file. The special entries can be entered either in the [General Info] section of your project's .CLW file or in the [ExtraDDX] section of the DDX.CLW file in the \Program Files\Microsoft Visual Studio\Visual C++\bin directory. You may need to create the DDX.CLW file if it doesn't already exist. If you plan to use the custom DDX_/DDV_ routines only in a certain project, add the entries to the [General Info] section of your project .CLW file instead. If you plan to use the routines on many projects, add the entries to the [ExtraDDX] section of DDX.CLW.  
  
 The general format of these special entries is:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 where n is the number of ExtraDDX? lines to follow  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 where ? is a number 1 – n indicating which DDX type in the list that is being defined.  
  
 Each field is delimited by a ';' character. The fields and their purpose are described below.  
  
 \<keys>  
 = list of single characters indicating for which dialog controls this variable type is allowed.  
  
 E = edit  
  
 C = two-state check box  
  
 c = tri-state check box  
  
 R = first radio button in a group  
  
 L = nonsorted list box  
  
 l = sorted list box  
  
 M = combo box (with edit item)  
  
 N = nonsorted drop list  
  
 n = sorted drop list  
  
 1 = if the DDX insert should be added to head of list (default is add to tail) This is generally used for DDX routines that transfer the 'Control' property.  
  
 \<vb-keys>  
 This field is used only in the 16-bit product for VBX controls (VBX controls are not supported in the 32-bit product)  
  
 \<prompt>  
 String to place in the Property combo box (no quotes)  
  
 \<type>  
 Single identifier for type to emit in the header file. In our example above with DDX_Time, this would be set to CTime.  
  
 \<vb-keys>  
 Not used in this version and should always be empty  
  
 \<initValue>  
 Initial value — 0 or blank. If it is blank, then no initialization line will be written in the //{{AFX_DATA_INIT section of the implementation file. A blank entry should be used for C++ objects (such as <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and so on) that have constructors that guarantee correct initialization.  
  
 \<DDX_Proc>  
 Single identifier for the DDX_ procedure. The C++ function name must start with "DDX_," but don't include "DDX_" in the \<DDX_Proc> identifier. In the example above, the \<DDX_Proc> identifier would be Time. When ClassWizard writes the function call to the implementation file in the {{AFX_DATA_MAP section, it appends this name to DDX_, thus arriving at DDX_Time.  
  
 \<comment>  
 Comment to show in dialog for variable with this DDX. Place any text you would like here, and usually provide something that describes the operation performed by the DDX/DDV pair.  
  
 \<DDV_Proc>  
 The DDV portion of the entry is optional. Not all DDX routines have corresponding DDV routines. Often, it is more convenient to include the validation phase as an integral part of the transfer. This is often the case when your DDV routine doesn't require any parameters, because ClassWizard does not support DDV routines without any parameters.  
  
 \<arg>  
 Single identifier for the DDV_ procedure. The C++ function name must start with "DDV_", but do not include "DDX_" in the \<DDX_Proc> identifier.  
  
 followed by 1 or 2 DDV args:  
  
 \<promptX>  
 string to place above the edit item (with & for accelerator)  
  
 \<fmtX>  
 format character for the arg type, one of  
  
 d = int  
  
 u = unsigned  
  
 D = long int (that is, long)  
  
 U = long unsigned (that is, DWORD)  
  
 f = float  
  
 F = double  
  
 s = string  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)