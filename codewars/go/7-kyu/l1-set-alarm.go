package kata


func SetAlarm(employed, vacation bool) bool {
  return employed && !vacation
}
// TODO: replace with your own tests (TDD). An example to get you started is included below.
// Ginkgo BDD Testing Framework <http://onsi.github.io/ginkgo/>
// Gomega Matcher Library <http://onsi.github.io/gomega/>

package kata_test
import (
  . "github.com/onsi/ginkgo"
  . "github.com/onsi/gomega"
  . "codewarrior/kata"
)


func dotest(a, b, expected bool) {
     Expect(SetAlarm(a, b)).To(Equal(expected), "With employed = %t, vacation = %t", a, b)
}

var _ = Describe("Tests", func() {
     It("Sample tests", func() {
       dotest(true, true, false)
       dotest(false, true, false)
       dotest(false, false, false)
       dotest(true, false, true)
     })
})