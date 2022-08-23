BeforeAll {
      Import-Module ./Retype/Retype/Retype.psd1
}

Describe 'Install-Retype' {
      It 'Makes sure Retype has installed' {
            Install-Retype
            $env:Path -match 'Retype' | Should -Be $true
      }
}
