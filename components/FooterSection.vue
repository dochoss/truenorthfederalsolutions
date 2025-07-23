<template>
  <footer class="bg-secondary-900 text-white">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
      <!-- Main Footer Content -->
      <div class="py-12 lg:py-16">
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8 lg:gap-12">
          <!-- Company Information -->
          <div class="lg:col-span-1">
            <div class="flex items-center space-x-2 mb-4">
              <NuxtImg src="/logo-side.svg" :placeholder="img(`/logo-side.svg`, { h: 50, f: 'png', q: 50 })"
                alt="True North Federal Solutions Logo" class="h-20 w-full bg-white rounded-lg p-2" />
              <!-- <span class="mt-2 text-white font-bold text-lg">True North <br /> Federal Solutions</span> -->
            </div>
            <p class="text-secondary-300 text-sm leading-relaxed mb-6">
              Expert federal contracting guidance from a seasoned contracting officer with 15+ years of experience.
              Navigate government procurement with confidence.
            </p>

            <!-- Contact Information -->
            <div class="space-y-3">
              <div class="flex items-center space-x-3">
                <Icon name="heroicons:envelope" class="w-4 h-4 text-primary-400" />
                <a href="mailto:contact@truenorthfederalsolutions.com"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  contact@truenorthfederalsolutions.com
                </a>
              </div>
              <div class="flex items-center space-x-3">
                <Icon name="heroicons:phone" class="w-4 h-4 text-primary-400" />
                <a href="tel:+1234567890" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  (123) 456-7890
                </a>
              </div>
              <div class="flex items-center space-x-3">
                <Icon name="heroicons:map-pin" class="w-4 h-4 text-primary-400" />
                <span class="text-secondary-300 text-sm">Serving Federal Agencies Nationwide</span>
              </div>
            </div>
          </div>

          <!-- Services -->
          <div>
            <h3 class="text-white font-semibold text-sm uppercase tracking-wider mb-4">Services</h3>
            <ul class="space-y-3">
              <li>
                <NuxtLink to="/services/contract-setup"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Contract Setup
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/proposal-development"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Proposal Development
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/far-compliance"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  FAR Compliance
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/bid-no-bid-strategy"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Strategic Consulting
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services"
                  class="text-primary-400 hover:text-primary-300 transition-colors text-sm font-medium">
                  View All Services →
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Resources -->
          <div>
            <h3 class="text-white font-semibold text-sm uppercase tracking-wider mb-4">Resources</h3>
            <ul class="space-y-3">
              <li>
                <NuxtLink to="/resources/guides" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Federal Contracting Guides
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/certifications"
                  class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Certifications & Training
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/blog" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Industry Insights
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources"
                  class="text-primary-400 hover:text-primary-300 transition-colors text-sm font-medium">
                  All Resources →
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Company -->
          <div>
            <h3 class="text-white font-semibold text-sm uppercase tracking-wider mb-4">Company</h3>
            <ul class="space-y-3">
              <li>
                <NuxtLink to="/about" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  About Us
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/contact" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Contact
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/privacy" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Privacy Policy
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/terms" class="text-secondary-300 hover:text-white transition-colors text-sm">
                  Terms of Service
                </NuxtLink>
              </li>
            </ul>

            <div class="mt-6">
              <h4 class="text-white font-medium text-sm mb-3">Connect With Us</h4>
              <Social />
            </div>
          </div>
        </div>
      </div>

      <!-- Bottom Footer -->
      <div class="border-t border-secondary-700 py-6">
        <div class="md:flex md:items-center md:justify-between">
          <div class="flex flex-col md:flex-row md:items-center md:space-x-6">
            <p class="text-secondary-400 text-sm">
              © {{ currentYear }} True North Federal Solutions. All rights reserved.
            </p>
            <div class="flex items-center space-x-4 mt-2 md:mt-0">
              <span class="text-secondary-500 text-xs">
                Veteran-Owned Small Business
              </span>
              <span class="text-secondary-500 text-xs">
                CAGE Code: Available Upon Request
              </span>
            </div>
          </div>

          <div class="mt-4 md:mt-0">
            <p class="text-secondary-500 text-xs">
              Designed with accessibility and compliance in mind
            </p>
          </div>
        </div>
      </div>
    </div>
  </footer>
</template>

<script setup>
// Footer component for True North Federal Solutions
// Updated to follow the design system
const img = useImage()
const currentYear = new Date().getFullYear()
</script>
