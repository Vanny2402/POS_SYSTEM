
function Initialize-Jenga {
  $action = 'Initialize'
  $project = Get-Project
  $projectFile = $project.FullName
  $genPath=Join-Path $PSScriptRoot Jenga.Cli.exe 
  &"$genPath" "$projectFile" $action
}
Export-ModuleMember -Function Initialize-Jenga

function Launch-Jenga {
  $action = 'Launch'
  $project = Get-Project
  $projectFile = $project.FullName
  $genPath=Join-Path $PSScriptRoot Jenga.Cli.exe 
  &"$genPath" "$projectFile" $action
}
Export-ModuleMember -Function Launch-Jenga 

function Generate-Jenga {
  $action = 'Generate'
  $project = Get-Project
  $projectFile = $project.FullName
  $genPath=Join-Path $PSScriptRoot Jenga.Cli.exe 
  &"$genPath" "$projectFile" $action
}
Export-ModuleMember -Function Generate-Jenga