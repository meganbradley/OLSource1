---
title: "How to: Configure the ClickOnce Trust Prompt Behavior"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, install without prompting"
  - "deploying applications [ClickOnce], trust prompt"
  - "ClickOnce applications, install without prompting"
  - "ClickOnce applications, trust prompt"
  - "ClickOnce deployment, trust prompt"
ms.assetid: cc04fa75-012b-47c9-9347-f4216be23cf2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Configure the ClickOnce Trust Prompt Behavior
You can configure the ClickOnce trust prompt to control whether end users are given the option of installing ClickOnce applications, such as Windows Forms applications, Windows Presentation Foundation applications, console applications, WPF browser applications, and Office solutions. You configure the trust prompt by setting registry keys on each end user's computer.  
  
 The following table shows the configuration options that can be applied to each of the five zones (Internet, UntrustedSites, MyComputer, LocalIntranet, and TrustedSites).  
  
|Option|Registry setting value|Description|  
|------------|----------------------------|-----------------|  
|Enable the trust prompt.|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The ClickOnce trust prompt is display so that end users can grant trust to ClickOnce applications.|  
|Restrict the trust prompt.|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The ClickOnce trust prompt is only displayed if ClickOnce applications are signed with a certificate that identifies the publisher.|  
|Disable the trust prompt.|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The ClickOnce trust prompt is not displayed for any ClickOnce applications that are not signed with an explicitly trusted certificate.|  
  
 The following table shows the default behavior for each zone. The Applications column refers to Windows Forms applications, Windows Presentation Foundation applications, WPF browser applications, and console applications.  
  
|Zone|Applications|Office solutions|  
|----------|------------------|----------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
 You can override these settings by enabling, restricting, or disabling the ClickOnce trust prompt.  
  
## Enabling the ClickOnce Trust Prompt  
 Enable the trust prompt for a zone when you want end users to be presented with the option of installing and running any ClickOnce application that comes from that zone.  
  
#### To enable the ClickOnce trust prompt by using the registry editor  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and then click **OK**.  
  
2.  Find the following registry key:  
  
     \HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel  
  
     If the key does not exist, create it.  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values shown in the following table.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
     For Office solutions, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> has the default value <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> has the value <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For all others, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has the default value <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
#### To enable the ClickOnce trust prompt programmatically  
  
1.  Create a Visual Basic or Visual C# console application in Visual Studio.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Build and run the application.  
  
## Restricting the ClickOnce Trust Prompt  
 Restrict the trust prompt so that solutions must be signed with Authenticode certificates that have known identity before users are prompted for a trust decision.  
  
#### To restrict the ClickOnce trust prompt by using the registry editor  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and then click **OK**.  
  
2.  Find the following registry key:  
  
     \HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel  
  
     If the key does not exist, create it.  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values shown in the following table.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
  
#### To restrict the ClickOnce trust prompt programmatically  
  
1.  Create a Visual Basic or Visual C# console application in Visual Studio.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  Build and run the application.  
  
## Disabling the ClickOnce Trust Prompt  
 You can disable the trust prompt so that end users are not given the option to install solutions that are not already trusted in their security policy.  
  
#### To disable the ClickOnce trust prompt by using the registry editor  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and then click **OK**.  
  
2.  Find the following registry key:  
  
     \HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel  
  
     If the key does not exist, create it.  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values shown in the following table.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
  
#### To disable the ClickOnce trust prompt programmatically  
  
1.  Create a Visual Basic or Visual C# console application in Visual Studio.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Build and run the application.  
  
## See Also  
 [ClickOnce Security](../vs140/securing-clickonce-applications.md)   
 [Code Access Security for ClickOnce Applications](../vs140/code-access-security-for-clickonce-applications.md)   
 [ClickOnce and Authenticode](../vs140/clickonce-and-authenticode.md)   
 [Trusted Application Deployment Overview](../vs140/trusted-application-deployment-overview.md)   
 [How to: Enable ClickOnce Security Settings](../vs140/how-to--enable-clickonce-security-settings.md)   
 [How to: Set a Security Zone for a ClickOnce Application](../vs140/how-to--set-a-security-zone-for-a-clickonce-application.md)   
 [How to: Set Custom Permissions for a ClickOnce Application](../vs140/how-to--set-custom-permissions-for-a-clickonce-application.md)   
 [How to: Debug a ClickOnce Application with Restricted Permissions](../vs140/how-to--debug-a-clickonce-application-with-restricted-permissions.md)   
 [How to: Add a Trusted Publisher to a Client Computer for ClickOnce Applications](../vs140/how-to--add-a-trusted-publisher-to-a-client-computer-for-clickonce-applications.md)   
 [How to: Re-sign Application and Deployment Manifests](../vs140/how-to--re-sign-application-and-deployment-manifests.md)