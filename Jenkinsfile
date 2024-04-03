pipeline {
    agent any
     environment {
        SONAR_SCANNER_HOME = tool 'SonarScanner'
        SONARQUBE_SCANNER_HOME = tool 'sonarqube'
        PATH = "$PATH:${env.SONAR_SCANNER_HOME}:${env.SONARQUBE_SCANNER_HOME}"
     }
     stages {
 
        stage('CLEAN WORKSPACE') {
            steps {
                cleanWs()
            }
        }
        
        stage('CODE CHECKOUT') {
            steps {
               git url:'https://github.com/AmitG07/DevOps-Assignment.git', branch :'feature/test'
                // checkout scm
            }
        }

        /*stage('BUILD') {
            steps {
                sh 'dotnet build'
            }
        }*/
        
        stage('SonarQube analysis') {
            steps {
                withSonarQubeEnv('sonarqube') {
                    sh "dotnet ${env.SONAR_SCANNER_HOME}/SonarScanner.MSBuild.dll begin /k:\"Devops-Sonarqube\" /d:sonar.host.url=\"http://localhost:9000\" /d:sonar.login=\"token_value\""
                    sh 'dotnet build'
                    sh "dotnet ${env.SONAR_SCANNER_HOME}/SonarScanner.MSBuild.dll end /d:sonar.login=\"token_value\""
                }
            }
        }
        
        stage('TEST') {
            steps {
                sh 'dotnet test'
            }
        }
    }      
}
