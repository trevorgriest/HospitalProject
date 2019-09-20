using System;
using Xunit;

namespace universityHospital.Tests
{
    public class universityHospitalTests
    {
        [Fact]
        public void TestBloodDraw()
        {
            Patient patient = new Patient();
            Doctor doctor = new Doctor("John",12342,"Brain");

            doctor.DrawBlood(patient);

            Assert.Equal(18, patient.blood);
        }
        [Fact]
        public void TestCareForPatient()
        {
            Patient patient = new Patient();
            Doctor doctor = new Doctor("John", 12342, "Brain");

            doctor.CareForPatient(patient);

            Assert.Equal(11, patient.health);
        }
        [Fact]
        public void TestPayEmployee()
        {
            Doctor doctor = new Doctor("John", 12342, "Brain");
            doctor.PayEmployee();

            Assert.Equal(true, doctor.isPaid);
        }

    }
}
