BeforeAll {
      Import-Module .\Retype\Retype.psd1
      $AddRetype = ';.\Retype'
      $Environment = $Environment.Insert($Environment.Length, $AddRetype)
      [System.Environment]::SetEnvironmentVariable('Path', $Environment, 'Machine')
}

Describe 'Install-Retype' {
      It 'Makes sure Retype has installed' {
            
            Install-Retype
            $Environment = [System.Environment]::GetEnvironmentVariable('Path', 'Machine')
            $Environment.length | Should -BeGreaterThan 10
            $env:Path -match 'Retype' | Should -Be $true
      }
}
