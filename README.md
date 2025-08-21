# BEAM-AR-Indoor-Navigation

An innovative Augmented Reality (AR) indoor navigation system that provides real-time wayfinding guidance using advanced computer vision and spatial computing technologies.

## Project Summary

BEAM-AR-Indoor-Navigation is a cutting-edge mobile application that revolutionizes indoor navigation by combining AR visualization with intelligent pathfinding algorithms. The system uses QR code positioning for accurate localization and provides intuitive AR guidance to help users navigate complex indoor environments like shopping malls, hospitals, airports, and office buildings.

## Key Features

### 🔍 AR Guidance
- Real-time augmented reality overlays showing directional arrows and path indicators
- 3D virtual waypoints and destination markers
- Interactive AR elements for enhanced user experience
- Distance and time-to-destination information

### 📱 QR Code Positioning
- Precise indoor localization using strategically placed QR codes
- Instant position calibration and orientation detection
- Seamless integration with existing building infrastructure
- Fallback positioning methods for improved reliability

### 🗺️ NavMesh Pathfinding
- Intelligent route calculation using Unity's NavMesh system
- Dynamic obstacle avoidance and path optimization
- Multi-floor navigation support
- Real-time path recalculation based on environmental changes

## Technologies Used

- **Unity 2022.3 LTS** - Primary development platform
- **AR Foundation 4.2+** - Cross-platform AR framework
- **ARCore** - Android AR capabilities
- **ARKit** - iOS AR capabilities (if supported)
- **Unity NavMesh** - Pathfinding and navigation system
- **ZXing.Net** - QR code scanning and generation
- **C#** - Primary programming language
- **Universal Render Pipeline (URP)** - Optimized rendering

## Setup Instructions

### Prerequisites
- Unity 2022.3 LTS or later
- Android Studio (for Android builds)
- Android device with ARCore support
- Git for version control

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/sainihaal2347/BEAM-AR-Indoor-Navigation.git
   cd BEAM-AR-Indoor-Navigation
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" and select the cloned project folder
   - Allow Unity to import all packages and dependencies

3. **Configure AR Settings**
   - Navigate to `Edit > Project Settings > XR Plug-in Management`
   - Enable ARCore (Android) or ARKit (iOS)
   - Verify AR Foundation package is installed

4. **Build Settings**
   - Go to `File > Build Settings`
   - Switch platform to Android or iOS
   - Add main scene to build
   - Configure player settings (package name, permissions, etc.)

5. **Deploy to Device**
   - Connect your AR-capable device
   - Build and run the application
   - Grant camera and location permissions when prompted

### QR Code Setup
- Generate QR codes for key locations using the provided QR code generator
- Place QR codes at strategic points (entrances, intersections, destinations)
- Update the location database with QR code positions and metadata

## Usage Scenarios

### 🏥 Healthcare Facilities
- Guide patients and visitors to specific departments, rooms, or facilities
- Provide accessibility-friendly navigation for individuals with mobility challenges
- Emergency evacuation route guidance

### 🏢 Corporate Offices
- Help new employees navigate large office complexes
- Visitor management and guided tours
- Conference room and facility location assistance

### 🛍️ Shopping Centers
- Store location and product finding
- Promotional content delivery at specific locations
- Event and sale navigation

### 🏫 Educational Institutions
- Campus navigation for students and visitors
- Classroom and facility location
- Interactive campus tours

### ✈️ Transportation Hubs
- Airport terminal navigation
- Gate and facility location
- Real-time updates for delays or changes

## Acknowledgments

- Unity Technologies for AR Foundation framework
- Google for ARCore SDK
- OpenCV community for computer vision resources
- Contributors and testers who helped improve the system

---

*Built with ❤️ using Unity and AR Foundation*
