#  
# Module manifest for module '%MODULE-NAME%'  
#  
# Generated by: Microsoft Corporation  
#  
# Generated on: %DATE%
#  

$PSDefaultParameterValues.Clear()
Set-StrictMode -Version Latest

# Import dependencies using required version, if it is allowed
if ($PSVersionTable.PSVersion.Major -ge 5)
{
%STRICT-DEPENDENCIES%
}
else
{
%DEPENDENCIES%
}
