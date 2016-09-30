---
title: "Button Styles"
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
  - "BS_DEFPUSHBUTTON"
  - "BS_NOTIFY"
  - "BS_MULTILINE"
  - "BS_AUTOCHECKBOX"
  - "BS_3STATE"
  - "BS_BITMAP"
  - "BS_TOP"
  - "BS_PUSHBUTTON"
  - "BS_PUSHLIKE"
  - "BS_AUTO3STATE"
  - "BS_CHECKBOX"
  - "BS_AUTORADIOBUTTON"
  - "BS_RADIOBUTTON"
  - "BS_OWNERDRAW"
  - "BS_LEFT"
  - "BS_USERBUTTON"
  - "BS_RIGHTBUTTON"
  - "BS_RIGHT"
  - "BS_LEFTTEXT"
  - "BS_TEXT"
  - "BS_BOTTOM"
  - "BS_GROUPBOX"
  - "BS_FLAT"
  - "BS_VCENTER"
  - "BS_ICON"
  - "BS_CENTER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BS_NOTIFY constant"
  - "BS_RIGHTBUTTON constant"
  - "styles, button objects"
  - "BS_USERBUTTON constant"
  - "BS_VCENTER constant"
  - "BS_PUSHLIKE constant"
  - "BS_RADIOBUTTON constant"
  - "BS_PUSHBUTTON constant"
  - "BS_DEFPUSHBUTTON constant"
  - "BS_LEFTTEXT constant"
  - "button objects (CButton), button styles"
  - "BS_AUTO3STATE constant"
  - "BS_3STATE constant"
  - "BS_OWNERDRAW constant"
  - "BS_AUTORADIOBUTTON constant"
  - "BS_GROUPBOX constant"
  - "BS_BITMAP constant"
  - "BS_CENTER constant"
  - "BS_MULTILINE constant"
  - "BS_BOTTOM constant"
  - "BS_FLAT constant"
  - "BS_AUTOCHECKBOX constant"
  - "BS_RIGHT constant"
  - "BS_CHECKBOX constant"
  - "BS_LEFT constant"
  - "BS_ICON constant"
  - "BS_TOP constant"
  - "BS_TEXT constant"
ms.assetid: 41206f72-2b92-4250-ae32-31184046402f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Button Styles
This topic describes button types and styles.  
  
## Button Types  
 The following table lists button types. You can optionally choose one of the following. If you do not specify a button type, the default is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
|Type|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Creates a check box button with three states: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Clicking on the button sends a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> notification to the owner window but does not change the state of the button. By default, associated text is displayed to the right of the check box. To display text to the left of the check box, use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Creates a check box button with three states: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Clicking on the button sends a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> notification to the owner window and changes the state of the button. The button states cycle in the order of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. By default, associated text is displayed to the right of the check box. To display text to the left of the check box, use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Creates a check box button with two states: <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Clicking on the button sends a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> notification to the owner window and changes the state of the button. By default, associated text is displayed to the right of the check box. To display text to the left of the check box, use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Creates a radio button with two states: <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Radio buttons are usually used in groups, with each group having a maximum of one checked option at a time. Clicking on the button sends a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> notification to the owner window, sets the state of the clicked radio button to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and sets the states of all other radio buttons in the button group to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. By default, associated text is displayed to the right of the radio button. To display text to the left of the radio button, use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Creates a check box button with two states: <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Clicking on the button sends a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> notification to the owner window but does not change the state of the button. By default, associated text is displayed to the right of the check box. To display text to the left of the check box, use the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Creates a command link button. A command link button is a command button specific to [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] that displays a green arrow to the left of the main text and a note below the main text. You can set the note text using [CButton::SetNote](../vs140/cbutton--setnote.md).|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Creates a command link button. A command link button is a command button specific to [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] that displays a green arrow to the left of the main text and a note below the main text. You can set the note text using [CButton::SetNote](../vs140/cbutton--setnote.md). If the button is in a dialog box, pressing the ENTER key sends a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> notification to the dialog box even when the button does not have the input focus.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Creates a command button that has a heavy black border. If the button is in a dialog box, pressing the ENTER key sends a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> notification to the dialog box even when the button does not have the input focus.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Creates a split button. A split button is a command button specific to [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] that contains a button adjacent to a drop-down arrow. When you click the button, the default command is executed. When you click the drop-down arrow, a menu of additional commands appears. If the split button is in a dialog box, pressing the ENTER key sends a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> notification to the dialog box even when the button does not have the input focus|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Creates a rectangle in which other buttons can be grouped. Text associated with this style is displayed in the rectangle's upper-left corner.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Creates an owner-drawn button. The framework calls the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method when a visual aspect of the button has changed. This style must be set when you use the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Creates a command button that sends a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> notification to the owner window when the user clicks the button.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Creates a radio button with two states: <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. Radio buttons are usually used in groups, with each group having a maximum of one checked option at a time. Clicking on the button sends a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> notification to the owner window but does not automatically change the state of any button in the group. By default, associated text is displayed to the right of the radio button. To display text to the left of the radio button, use the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Creates a split button. A split button is a command button specific to [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] that contains a button adjacent to a drop-down arrow. When you click the button, the default command is executed. When you click the drop-down arrow, a menu of additional commands appears.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Obsolete, but provided for compatibility with 16-bit versions of Windows. Win32-based applications should use <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> instead.|  
  
## Radio Button and Check Box Styles  
 The following table lists styles that are specific to radio buttons and check boxes. These styles are ignored in all other button types. You can optionally choose one or more of the following.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|When combined with a radio button or check-box style, the text appears on the left side of the radio button or check box.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|When combined with a radio button or check-box style, the text appears on the left side of the radio button or check box. This style is identical to the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> style.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Makes a check box or radio button look and behave like a command button. The button appears pressed when its state is <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, pressed and dimmed when its state is <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and released when its state is <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.|  
  
## Text Alignment Styles  
 The following table lists horizontal and vertical text alignment options. You can optionally choose one of the following.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Left aligns the text in the button rectangle. However, if the button is a check box or radio button that does not have the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> style, the text is left aligned on the right side of the check box or radio button.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Right aligns the text in the button rectangle. However, if the button is a check box or radio button that does not have the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> style, the text is right aligned on the right side of the check box or radio button.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Centers text horizontally in the button rectangle.|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|Places text at the top of the button rectangle.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Places text at the bottom of the button rectangle.|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Centers text vertically in the button rectangle.|  
  
## Button Content Options  
 The following table lists options that indicate what is displayed in the button. Button types that only display text ignore these styles. You can optionally choose one of the following.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Specifies that the button displays a bitmap.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Specifies that the button displays an icon.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Specifies that the button displays text.|  
  
## Other Options  
 The following table lists additional options that you can use with any button type. You can optionally choose one or more of the following.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Specifies that the button is two-dimensional and is not drawn with default shading to create a three-dimensional image.|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Wraps the button text to multiple lines if the text string is too long to fit on a single line in the button rectangle.|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|Enables a button to send <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> notification messages to its parent window. Note that buttons send the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> notification regardless of whether this style is specified.|  
  
## See Also  
 [Styles Used by MFC](../vs140/styles-used-by-mfc.md)   
 [CButton::Create](../vs140/cbutton--create.md)   
 [Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb775951)   
 [BN_CLICKED Notification](_win32_bn_clicked_notification)