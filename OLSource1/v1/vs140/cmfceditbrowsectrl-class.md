---
title: "CMFCEditBrowseCtrl Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMFCEditBrowseCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCEditBrowseCtrl::PreTranslateMessage method"
  - "CMFCEditBrowseCtrl constructor"
  - "CMFCEditBrowseCtrl class"
ms.assetid: 69cfd886-3d35-4bee-8901-7c88fcf9520f
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCEditBrowseCtrl Class
The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class supports the edit browse control, which is an editable text box that optionally contains a browse button. When the user clicks the browse button, the control performs a custom action or displays a standard dialog box that contains a file browser or a folder browser.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCEditBrowseCtrl::EnableBrowseButton](#cmfceditbrowsectrl__enablebrowsebutton)|Enables or disables (hides) the browse button.|  
|[CMFCEditBrowseCtrl::EnableFileBrowseButton](#cmfceditbrowsectrl__enablefilebrowsebutton)|Enables the browse button and puts the edit browse control in *file browse* mode.|  
|[CMFCEditBrowseCtrl::EnableFolderBrowseButton](#cmfceditbrowsectrl__enablefolderbrowsebutton)|Enables the browse button and puts the edit browse control in *folder browse* mode.|  
|[CMFCEditBrowseCtrl::GetMode](#cmfceditbrowsectrl__getmode)|Returns the current browse mode.|  
|[CMFCEditBrowseCtrl::OnAfterUpdate](#cmfceditbrowsectrl__onafterupdate)|Called by the framework after the edit browse control is updated with the result of a browse action.|  
|[CMFCEditBrowseCtrl::OnBrowse](#cmfceditbrowsectrl__onbrowse)|Called by the framework after the user clicks the browse button.|  
|[CMFCEditBrowseCtrl::OnChangeLayout](#cmfceditbrowsectrl__onchangelayout)|Redraws the current edit browse control.|  
|[CMFCEditBrowseCtrl::OnDrawBrowseButton](#cmfceditbrowsectrl__ondrawbrowsebutton)|Called by the framework to draw the browse button.|  
|[CMFCEditBrowseCtrl::OnIllegalFileName](#cmfceditbrowsectrl__onillegalfilename)|Called by the framework when an illegal file name was entered in the edit control.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Translates window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. For syntax and more information, see [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).|  
|[CMFCEditBrowseCtrl::SetBrowseButtonImage](#cmfceditbrowsectrl__setbrowsebuttonimage)|Sets a custom image for the browse button.|  
  
## Remarks  
 Use an edit browse control to select a file or folder name. Optionally, use the control to perform a custom action such as to display a dialog box. You can display or not display the browse button, and you can apply a custom label or image on the button.  
  
 The *browse mode* of the edit browse control determines whether it displays a browse button and what action occurs when the button is clicked. For more information, see the [GetMode](#cmfceditbrowsectrl__getmode) method.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class supports the following modes.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A custom action is performed when the user clicks the browse button. For example, you can display an application-specific dialog box.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A standard file selection dialog box is displayed when the user clicks the browse button.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A standard folder selection dialog box is displayed when the user clicks the browse button.  
  
## How-To: Specify an Edit Browse Control  
 Perform the following steps to incorporate an edit browse control in your application:  
  
1.  If you want to implement a custom browse mode, derive your own class from the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class and then override the [OnBrowse](#cmfceditbrowsectrl__onbrowse) method. In the overridden method, execute a custom browse action and update the edit browse control with the result.  
  
2.  Embed either the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object or the derived edit browse control object into the parent window object.  
  
3.  If you use the **Class Wizard** to create a dialog box, add an edit control ( <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) to the dialog box form. Also, add a variable to access the control in your header file. In your header file, change the type of the variable from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The edit browse control will be created automatically. If you do not use the **Class Wizard**, add a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> variable to your header file and then call its <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method.  
  
4.  If you add an edit browse control to a dialog box, use the **ClassWizard** tool to set up data exchange.  
  
5.  Call the [EnableFolderBrowseButton](#cmfceditbrowsectrl__enablefolderbrowsebutton), [EnableFileBrowseButton](#cmfceditbrowsectrl__enablefilebrowsebutton), or [EnableBrowseButton](#cmfceditbrowsectrl__enablebrowsebutton) method to set the browse mode and display the browse button. Call the [GetMode](#cmfceditbrowsectrl__getmode) method to obtain the current browse mode.  
  
6.  To provide a custom image for the browse button, call the [SetBrowseButtonImage](#cmfceditbrowsectrl__setbrowsebuttonimage) method or override the [OnDrawBrowseButton](#cmfceditbrowsectrl__ondrawbrowsebutton) method.  
  
7.  To remove the browse button from the edit browse control, call the [EnableBrowseButton](#cmfceditbrowsectrl__enablebrowsebutton) method with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter set to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CEdit](../vs140/cedit-class.md)  
  
 [CMFCEditBrowseCtrl](../vs140/cmfceditbrowsectrl-class.md)  
  
## Example  
 The following example demonstrates how to use two methods in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class: <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#6](../vs140/codesnippet/CPP/cmfceditbrowsectrl-class_1.h)]  
[!code[NVC_MFC_NewControls#7](../vs140/codesnippet/CPP/cmfceditbrowsectrl-class_2.cpp)]  
  
## Requirements  
 **Header:** afxeditbrowsectrl.h  
  
##  \<a name="cmfceditbrowsectrl__enablebrowsebutton">\</a>  CMFCEditBrowseCtrl::EnableBrowseButton  
 Displays or does not display the browse button on the current edit browse control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to display the browse button; <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> not to display the browse button. The default value is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The label that is displayed on the browse button. The default value is " **...**".  
  
### Remarks  
 If the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, implement a custom action to perform when the browse button is clicked. To implement a custom action, derive a class from the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class and then override its [OnBrowse](#cmfceditbrowsectrl__onbrowse) method.  
  
 If the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the browse mode of the control is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>; otherwise, the browse mode is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. For more information about browse modes, see the [GetMode](#cmfceditbrowsectrl__getmode) method.  
  
##  \<a name="cmfceditbrowsectrl__enablefilebrowsebutton">\</a>  CMFCEditBrowseCtrl::EnableFileBrowseButton  
 Displays the browse button on the current edit browse control and puts the control in *file browse* mode.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies the default file name extension that is used in the file selection dialog box. The default value is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the default filter string that is used in the file selection dialog box. The default value is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Dialog box flags. The default value is a bitwise combination (OR) of OFN_HIDEREADONLY and OFN_OVERWRITEPROMPT.  
  
### Remarks  
 When the edit browse control is in file browse mode and the user clicks the browse button, the control displays the standard file selection dialog box.  
  
 For a full list of available flags, see                         [OPENFILENAME structure](https://msdn.microsoft.com/library/ms646839.aspx).  
  
##  \<a name="cmfceditbrowsectrl__enablefolderbrowsebutton">\</a>  CMFCEditBrowseCtrl::EnableFolderBrowseButton  
 Displays the browse button on the current edit browse control and puts the control in *folder browse* mode.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 When the edit browse control is in folder browse mode and the user clicks the browse button, the control displays the standard folder selection dialog box.  
  
##  \<a name="cmfceditbrowsectrl__getmode">\</a>  CMFCEditBrowseCtrl::GetMode  
 Retrieves the browse mode of the current edit browse control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 One of the enumeration values that specifies the current mode of the edit browse control. The browse mode determines whether the framework displays the browse button and what action occurs when a user clicks that button.  
  
 The following table lists the possible return values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. A programmer-defined action is performed.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. The standard file browser dialog box is displayed.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. The standard folder browser dialog box is displayed.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|The browse button is not displayed.|  
  
### Remarks  
 By default, a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object is initialized to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> mode. Modify the browse mode with the [EnableBrowseButton](#cmfceditbrowsectrl__enablebrowsebutton), [EnableFileBrowseButton](#cmfceditbrowsectrl__enablefilebrowsebutton), and [EnableFolderBrowseButton](#cmfceditbrowsectrl__enablefolderbrowsebutton) methods.  
  
##  \<a name="cmfceditbrowsectrl__onafterupdate">\</a>  CMFCEditBrowseCtrl::OnAfterUpdate  
 Called by the framework after the edit browse control is updated with the result of a browse action.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Override this method in a derived class to implement a custom action.  
  
##  \<a name="cmfceditbrowsectrl__onbrowse">\</a>  CMFCEditBrowseCtrl::OnBrowse  
 Called by the framework after the user clicks the browse button of the edit browse control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Use this method to execute custom code when the user clicks the browse button of the edit browse control. Derive your own class from the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> class and override its <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> method. In that method, implement a custom browse action and optionally update the text box of the edit browse control. In your application, use the [EnableBrowseButton](#cmfceditbrowsectrl__enablebrowsebutton) method to put the edit browse control in *custom browse* mode.  
  
##  \<a name="cmfceditbrowsectrl__onchangelayout">\</a>  CMFCEditBrowseCtrl::OnChangeLayout  
 Redraws the current edit browse control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when the browse mode of the edit browse control changes. For more information, see [CMFCEditBrowseCtrl::GetMode](#cmfceditbrowsectrl__getmode).  
  
##  \<a name="cmfceditbrowsectrl__ondrawbrowsebutton">\</a>  CMFCEditBrowseCtrl::OnDrawBrowseButton  
 Called by the framework to draw the browse button on the edit browse control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The bounding rectangle of the browse button.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> if the button is pressed; otherwise, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> if the button is highlighted; otherwise, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function in a derived class to customize the appearance of the browse button.  
  
##  \<a name="cmfceditbrowsectrl__setbrowsebuttonimage">\</a>  CMFCEditBrowseCtrl::SetBrowseButtonImage  
 Sets a custom image on the browse button of the edit browse control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The handle of an icon.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The handle of a bitmap.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The resource ID of a bitmap.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to delete the specified icon or bitmap when this method exits; otherwise, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to apply a custom image to the browse button. By default, the framework obtains a standard image when the edit browse control is in *file browse* or *folder browse* mode.  
  
##  \<a name="cmfceditbrowsectrl__onillegalfilename">\</a>  CMFCEditBrowseCtrl::OnIllegalFileName  
 Called by the framework when an illegal file name was entered in the edit control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies the illegal file name.  
  
### Return Value  
 Should return <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if this file name can not be passed further to the file dialog. In this case, focus is set back to the edit control and the user should continue editing. The default implementation displays a message box telling the user about the illegal file name and returns <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. You can override this method, correct the file name, and return <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> for further processing.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)