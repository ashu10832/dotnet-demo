pipeline {
    agent any

    stages {
        stage('Build'){
            steps{
                bat 'git log'
                bat 'dotnet build'
            }
        }
        stage('Unit Test'){
            steps{
	            bat 'dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura'
                step([$class: 'Mailer', notifyEveryUnstableBuild: true, recipients: 'ashu10832@gmail.com', sendToIndividuals: false])
            }
        }
        stage('Code Coverage'){
            steps{
                cobertura autoUpdateHealth: false, autoUpdateStability: false, coberturaReportFile: '**\\FirstcoreProject\\coverage.cobertura.xml', conditionalCoverageTargets: '70, 80, 80', failUnhealthy: true, failUnstable: true, lineCoverageTargets: '80, 80, 80', maxNumberOfBuilds: 0, methodCoverageTargets: '80, 80, 80', onlyStable: false, sourceEncoding: 'ASCII', zoomCoverageChart: false
                step([$class: 'Mailer', notifyEveryUnstableBuild: true, recipients: 'ashu10832@gmail.com', sendToIndividuals: false])
            }
        }
        stage('Publish'){
            steps{
                bat 'dotnet publish'
            }
        }
        stage('Run'){
            steps{
                bat 'cd firstcoreproject'
                bat 'dotnet run --project firstcoreproject'
            }
        }
    }
}
