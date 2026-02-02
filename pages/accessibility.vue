<template>
  <div>
    <Hero title="Accessibility Statement"
          subtitle="Our commitment to making federal contracting guidance accessible to everyone"
          background-class="bg-gradient-to-r from-blue-600 to-blue-800" />

    <UPageSection>
      <div class="max-w-4xl mx-auto">
        <div class="space-y-12">
          <!-- Our Commitment -->
          <div>
            <h2 class="text-3xl font-bold mb-6">Our Commitment to Accessibility
            </h2>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  True North Federal Solutions is committed to ensuring that our
                  website is accessible to everyone, including individuals with
                  disabilities. We believe that everyone should have equal
                  access to information and resources about federal contracting
                  opportunities.
                </p>
                <p class="text-gray-600">
                  We are continuously working to improve the accessibility of
                  our website and ensure it meets or exceeds the standards
                  outlined in the Web Content Accessibility Guidelines (WCAG)
                  2.1 Level AA.
                </p>
              </div>
            </UCard>
          </div>

          <!-- Accessibility Features -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Accessibility Features</h3>
            <div class="grid md:grid-cols-2 gap-6">
              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-eye"
                           class="w-6 h-6 text-blue-600 mr-2" />
                    Visual Accessibility
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• High contrast color schemes</li>
                    <li>• Scalable text and images</li>
                    <li>• Alternative text for images</li>
                    <li>• Clear visual hierarchy</li>
                    <li>• Focus indicators for keyboard navigation</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-computer-desktop"
                           class="w-6 h-6 text-blue-600 mr-2" />
                    Technical Accessibility
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Keyboard navigation support</li>
                    <li>• Screen reader compatibility</li>
                    <li>• Semantic HTML structure</li>
                    <li>• ARIA labels and landmarks</li>
                    <li>• Mobile-responsive design</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-document-text"
                           class="w-6 h-6 text-blue-600 mr-2" />
                    Content Accessibility
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Plain language writing</li>
                    <li>• Clear headings and structure</li>
                    <li>• Descriptive link text</li>
                    <li>• Logical reading order</li>
                    <li>• Multiple ways to find content</li>
                  </ul>
                </div>
              </UCard>

              <UCard>
                <div class="p-6">
                  <h4 class="text-lg font-semibold mb-4 flex items-center">
                    <UIcon name="i-heroicons-cog-6-tooth"
                           class="w-6 h-6 text-blue-600 mr-2" />
                    User Controls
                  </h4>
                  <ul class="space-y-2 text-gray-600">
                    <li>• Text size adjustment options</li>
                    <li>• Video and audio controls</li>
                    <li>• Form validation and error messages</li>
                    <li>• Timeout warnings and extensions</li>
                    <li>• Skip navigation links</li>
                  </ul>
                </div>
              </UCard>
            </div>
          </div>

          <!-- Standards Compliance -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Standards Compliance</h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  Our website strives to conform to the following accessibility
                  standards:
                </p>
                <ul class="space-y-3 text-gray-600">
                  <li class="flex items-start">
                    <UIcon name="i-heroicons-check-circle"
                           class="w-5 h-5 text-green-600 mr-2 mt-0.5 shrink-0" />
                    <span><strong>WCAG 2.1 Level AA:</strong> Web Content
                      Accessibility Guidelines for web accessibility</span>
                  </li>
                  <li class="flex items-start">
                    <UIcon name="i-heroicons-check-circle"
                           class="w-5 h-5 text-green-600 mr-2 mt-0.5 shrink-0" />
                    <span><strong>Section 508:</strong> Federal standards for
                      electronic accessibility</span>
                  </li>
                  <li class="flex items-start">
                    <UIcon name="i-heroicons-check-circle"
                           class="w-5 h-5 text-green-600 mr-2 mt-0.5 shrink-0" />
                    <span><strong>ADA Compliance:</strong> Americans with
                      Disabilities Act requirements</span>
                  </li>
                </ul>
              </div>
            </UCard>
          </div>

          <!-- Assistive Technologies -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Supported Assistive Technologies
            </h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  Our website has been tested with the following assistive
                  technologies:
                </p>
                <div class="grid md:grid-cols-2 gap-4">
                  <div>
                    <h4 class="font-semibold mb-3">Screen Readers</h4>
                    <ul class="space-y-1 text-gray-600">
                      <li>• NVDA (Windows)</li>
                      <li>• JAWS (Windows)</li>
                      <li>• VoiceOver (macOS/iOS)</li>
                      <li>• TalkBack (Android)</li>
                    </ul>
                  </div>
                  <div>
                    <h4 class="font-semibold mb-3">Other Tools</h4>
                    <ul class="space-y-1 text-gray-600">
                      <li>• Voice recognition software</li>
                      <li>• Keyboard-only navigation</li>
                      <li>• Screen magnification</li>
                      <li>• Browser zoom (up to 200%)</li>
                    </ul>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Known Issues -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Known Accessibility Issues</h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  We are aware of the following accessibility issues and are
                  working to address them:
                </p>
                <div class="space-y-3">
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle"
                           class="w-5 h-5 text-amber-500 mr-2 mt-0.5 shrink-0" />
                    <div>
                      <h4 class="font-medium">Third-party Content</h4>
                      <p class="text-gray-600 text-sm">Some embedded content
                        from third-party providers may not meet our
                        accessibility standards.</p>
                    </div>
                  </div>
                  <div class="flex items-start">
                    <UIcon name="i-heroicons-exclamation-triangle"
                           class="w-5 h-5 text-amber-500 mr-2 mt-0.5 shrink-0" />
                    <div>
                      <h4 class="font-medium">PDF Documents</h4>
                      <p class="text-gray-600 text-sm">Some older PDF documents
                        may not be fully accessible. We are working to remediate
                        these.</p>
                    </div>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Feedback and Contact -->
          <div>
            <h3 class="text-2xl font-bold mb-6">Accessibility Feedback</h3>
            <UCard>
              <div class="p-6">
                <p class="text-gray-600 mb-4">
                  We welcome your feedback on the accessibility of our website.
                  If you encounter any accessibility barriers or have
                  suggestions for improvement, please contact us:
                </p>
                <div class="grid md:grid-cols-2 gap-6">
                  <div>
                    <h4 class="font-semibold mb-2">Contact Information</h4>
                    <ul class="space-y-2 text-gray-600">
                      <li class="flex items-center">
                        <UIcon name="i-heroicons-envelope"
                               class="w-4 h-4 mr-2" />
                        info@truenorthfederalconsulting.com
                      </li>
                      <li class="flex items-center">
                        <UIcon name="i-heroicons-phone"
                               class="w-4 h-4 mr-2" />
                        (555) 123-4567
                      </li>
                    </ul>
                  </div>
                  <div>
                    <h4 class="font-semibold mb-2">Response Time</h4>
                    <p class="text-gray-600 text-sm">
                      We aim to respond to accessibility feedback within 2
                      business days and resolve issues within 10 business days
                      when possible.
                    </p>
                  </div>
                </div>
              </div>
            </UCard>
          </div>

          <!-- Ongoing Efforts -->
          <div class="bg-blue-50 rounded-lg p-8">
            <h3 class="text-2xl font-bold text-blue-900 mb-4 text-center">
              Our Ongoing Commitment
            </h3>
            <p class="text-blue-700 text-center mb-6">
              Accessibility is an ongoing effort. We regularly audit our
              website, provide staff training, and update our practices to
              ensure everyone can access our federal contracting resources.
            </p>
            <div class="text-center">
              <UButton color="primary"
                       to="/contact">
                Report Accessibility Issue
              </UButton>
            </div>
          </div>
        </div>
      </div>
    </UPageSection>
  </div>
</template>

<script setup>
definePageMeta({
  title: 'Accessibility Statement',
  description: 'Our commitment to web accessibility and ensuring equal access to federal contracting resources for all users.'
})
</script>